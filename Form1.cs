using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTF8_Convert_Setup
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnFindInstallPath_Click(object sender, EventArgs e)
        {
            try
            {
                dlgInstallPath.ShowDialog();

                if (dlgInstallPath.SelectedPath != string.Empty)
                {
                    edtInstallPath.Text = dlgInstallPath.SelectedPath;
                }
            }
            catch (Exception dlgError)
            {
                MessageBox.Show("An error occurred while attempting to browse for the install path:\n" + dlgError.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private void btnBrowseTarget_Click(object sender, EventArgs e)
        {

            try
            {
                dlgTargetFile.ShowDialog();

                if (dlgTargetFile.FileName != string.Empty)
                {
                    edtTargwetFile.Text = dlgTargetFile.FileName;
                }
            }
            catch (Exception dlgError)
            {
                MessageBox.Show("An error occurred while attempting to browse for the target file:\n" + dlgError.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExportScruipts_Click(object sender, EventArgs e)
        {
            if (edtInstallPath.Text != string.Empty)
            {
                //Start File Creation
                string ExtractPath = edtInstallPath.Text;
                string TargetFile = edtTargwetFile.Text;

                if (ExtractPath[ExtractPath.Length - 1] == '\\')
                {
                    ExtractPath = ExtractPath + "UTF8Convert";
                }
                else
                {
                    ExtractPath = ExtractPath + "\\UTF8Convert";
                }

                //check if directory exist
                if (!Directory.Exists(ExtractPath))
                {
                    Directory.CreateDirectory(ExtractPath);
                }

                //Now start to write our scripts

                //Write the powershell script
                using (StreamWriter PowerShellScript = new StreamWriter(Path.Combine(ExtractPath, "ConvertToUTF8.ps1")))
                {
                    PowerShellScript.WriteLine("param([string]$MyFile)");
                    PowerShellScript.WriteLine("$SourceFile = $MyFile");
                    PowerShellScript.WriteLine("$tmpSourceFile=\"$SourceFile\" + \".tmp\"");
                    PowerShellScript.WriteLine("Write-Host \"Converting File to UTF8: $SourceFile\"");
                    PowerShellScript.WriteLine("Start-Sleep -Seconds 2");
                    PowerShellScript.WriteLine("Copy-Item $SourceFile $tmpSourceFile");
                    PowerShellScript.WriteLine("Start-Sleep -Seconds 1");
                    PowerShellScript.WriteLine("$MyRawString = Get-Content -Raw $tmpSourceFile");
                    PowerShellScript.WriteLine("$Utf8NoBomEncoding = New-Object System.Text.UTF8Encoding $False");
                    PowerShellScript.WriteLine("[System.IO.File]::WriteAllLines($SourceFile, $MyRawString, $Utf8NoBomEncoding)");
                    PowerShellScript.WriteLine("Start-Sleep -Seconds 1");
                    PowerShellScript.WriteLine("Remove-Item -Path $tmpSourceFile");
                    PowerShellScript.WriteLine("Exit-PSHostProcess");
                }

                //Write the callable bat file
                using (StreamWriter BatFile = new StreamWriter(Path.Combine(ExtractPath, "UTF8Convert.bat")))
                {
                    BatFile.WriteLine("@echo off");
                    BatFile.WriteLine("rem This calls our convert powershell script");
                    BatFile.WriteLine("SET File=" + TargetFile);
                    BatFile.WriteLine(@"SET PSScript=" + Path.Combine(ExtractPath, "ConvertToUTF8.ps1"));
                    BatFile.WriteLine("powershell -command \"%PSScript% -MyFile \\\"%File%\\\"\"");
                }

                MessageBox.Show("Scripts extracted to:\n" + ExtractPath,"Completed",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                //Show error
                MessageBox.Show("Install/Extract path may not be empty","Cannot Continue",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
