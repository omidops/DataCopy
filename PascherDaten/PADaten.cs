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

namespace PascherDaten
{
    public partial class PADaten : Form
    {
        public PADaten()
        {
            InitializeComponent();
        }

        private void tabCnt_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PADaten_Load(object sender, EventArgs e)
        {
        }

        private void btnRun_Click(object sender, EventArgs e)
        {            
            string Src_FOLDER = txtboxSrcPath.Text;
            if (Src_FOLDER.Length < 3 && !Directory.Exists(Src_FOLDER))
            {
                errorProvider1.SetError(txtboxSrcPath, "Please Enter a valid Path");
                return;
            }

            string Dst_FOLDER = txtBoxDstPath.Text;
            if (Dst_FOLDER.Length < 3 && !Directory.Exists(Dst_FOLDER))
            {
                errorProvider1.SetError(txtBoxDstPath, "Please Enter a valid Path");
                return;
            }
            btnRun.Enabled = false;
        
            Task.Run(()=> { CopyFiles(Src_FOLDER, Dst_FOLDER); });
           


            //Helper.CopyFilesInSelectedTime(Src_FOLDER, Dst_FOLDER, startTime, endTime);

            /*
            string[] originalFiles = Directory.GetFiles(Src_FOLDER, "*", SearchOption.AllDirectories);

            DateTime last30days = DateTime.Today.AddDays(-30);
            originalFiles = Directory.GetFiles(Src_FOLDER, "*", SearchOption.AllDirectories)
                .Where(file => new FileInfo(file).LastWriteTime.Date >= last30days)
                .ToArray();

            DateTime last7days = DateTime.Today.AddDays(-7);
            originalFiles = Directory.GetFiles(Src_FOLDER, "*", SearchOption.AllDirectories)
                .Where(file => new FileInfo(file).LastWriteTime.Date >= last7days)
                .ToArray();

            Array.ForEach(originalFiles, (originalFileLocation) =>
            {
                FileInfo originalFile = new FileInfo(originalFileLocation);
                FileInfo destFile = new FileInfo(originalFileLocation.Replace(Src_FOLDER, Dst_FOLDER));

                if (destFile.Exists)
                {
                    if (originalFile.Length > destFile.Length)
                    {
                        originalFile.CopyTo(destFile.FullName, true);
                    }
                }
                else
                {
                    Directory.CreateDirectory(destFile.DirectoryName);
                    originalFile.CopyTo(destFile.FullName, false);
                }
            });
            */
        }
        private async Task CopyFiles(string Src_FOLDER, string Dst_FOLDER)           
        {
            
            DateTime startTime = dateTimePickerFrom.Value.Date;
            DateTime endTime = dateTimePickerTil.Value.Date.AddSeconds(86400 - 1);

            procBar.BeginInvoke((MethodInvoker)(() =>
            //this.UIThreadAsync(delegate
            {
                int process = 1;
                procBar.Value = process;
                procBar.PerformStep();
                //});
            }));
     
               var files = Directory
                             .GetFiles(Src_FOLDER, "*", SearchOption.AllDirectories)
                             .ToList()
                             .ConvertAll(file => new FileInfo(file))
                             .Where(file => file.LastWriteTime.Date >= startTime && file.LastWriteTime.Date <= endTime);

               procBar.BeginInvoke((MethodInvoker)(() =>
               //this.UIThreadAsync(delegate 
               {
                   int process = 10;
                   procBar.Value = process;
                   lbPerzentage.Text = $"{process} %";
                   procBar.PerformStep();
                   procBar.Refresh();
                   lbtotalFilevalue.Text = files.Count().ToString();
                   //});
               }));
               //System.Threading.Thread.Sleep(3000);
               
               if (files.Count() < 1)
               {
                    procBar.BeginInvoke((MethodInvoker)(() =>
                    //this.UIThreadAsync(delegate 
                    {
                        procBar.Value = 100;
                       lbPerzentage.Text = $"{procBar.Value} %";
                        btnRun.Enabled = true;
                    }));
                    return;
               }

               int fileindex = 1;
               var filecnt = files.Count() + 1;
               Parallel.ForEach(files, (file) =>
               {
                   FileInfo destFile = new FileInfo(file.FullName.Replace(Src_FOLDER, Dst_FOLDER));

                   if (destFile.Exists)
                   {
                       if (file.Length > destFile.Length)
                       {
                           file.CopyTo(destFile.FullName, true);
                       }
                   }
                   else
                   {
                       Directory.CreateDirectory(destFile.DirectoryName);
                       file.CopyTo(destFile.FullName, false);
                   }
                   //procBar.BeginInvoke((MethodInvoker)(() =>
                   this.UIThreadAsync(delegate
                      {
                          int process = (int)(10 + (fileindex / filecnt * 90));
                          procBar.Value = process;
                          lbPerzentage.Text = $"{process} %";
                          procBar.PerformStep();
                          procBar.Refresh();
                       //}));
                   });
                   fileindex++;
                   //if (fileindex >= filecnt)
                   //    btnRun.BeginInvoke((MethodInvoker)(() => { btnRun.Enabled = true; }));
               });

               // procBar.BeginInvoke((MethodInvoker)(() => { procBar.Visible = false; }));
               //System.Threading.Thread.Sleep(300);
               if (fileindex >= filecnt)
               {
                   this.UIThreadAsync(delegate
                   { btnRun.Enabled = true; });
               }
        //   });
          //  frmprog.ShowDialog();
            //   btnRun.BeginInvoke((MethodInvoker)(() => { btnRun.Enabled = true; }));
        }

        private void btnSrcPath_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var result = folderBrowserDialog1.ShowDialog();
            if(result==DialogResult.OK)
            {
                txtboxSrcPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnDstPath_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBoxDstPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

     

        private void btnPathSeletor_Click(object sender, EventArgs e)
        {
            var result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtBoxPath.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void btnRunDel_Click(object sender, EventArgs e)
        {
            string path = txtBoxPath.Text;

            DateTime selectedtime = dateTimePickerDTil.Value.Date;

            

            Helper.DeleteFiles(path, selectedtime);
        }

        private void cmboxScenario_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = cmboxScenario.SelectedIndex;

            switch (index)
            {
                case 0:
                    dateTimePickerFrom.Value = DateTime.Now.Date;
                    dateTimePickerTil.Value = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
                    dateTimePickerFrom.Enabled = dateTimePickerTil.Enabled = false;
                    break;
                case 1:
                    dateTimePickerFrom.Value = DateTime.Now.Date.AddDays(-7);
                    dateTimePickerTil.Value = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
                    dateTimePickerFrom.Enabled = dateTimePickerTil.Enabled = false;
                    break;
                case 2:
                    dateTimePickerFrom.Value = DateTime.Now.Date.AddDays(-14);
                    dateTimePickerTil.Value = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
                    dateTimePickerFrom.Enabled = dateTimePickerTil.Enabled = false;
                    break;
                case 3:
                    dateTimePickerFrom.Value = DateTime.Now.Date.AddDays(-30);
                    dateTimePickerTil.Value = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
                    dateTimePickerFrom.Enabled = dateTimePickerTil.Enabled = false;
                    break;
                case 4:
                    dateTimePickerFrom.Value = DateTime.Now.Date.AddDays(-45);
                    dateTimePickerTil.Value = DateTime.Now.Date.AddDays(1).AddMilliseconds(-1);
                    dateTimePickerFrom.Enabled = dateTimePickerTil.Enabled = false;
                    break;
                case 5:
                    dateTimePickerFrom.Enabled = dateTimePickerTil.Enabled = true;
                    break;

                default:
                    break;
            }
        }
    }
}
