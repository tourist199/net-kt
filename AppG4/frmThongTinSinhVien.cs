﻿using AppG4.Model;
using AppG4.Service;
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

namespace AppG4
{
    public partial class frmThongTinSinhVien : Form
    {
        string anhDaiDienPathDirectory;
        string anhDaiDienPathFile;
        string studentPathFile;
        string historyPathFile;
        public frmThongTinSinhVien(string idStudent)
        {
            InitializeComponent();
            picAnhDaiDien.AllowDrop = true;
            anhDaiDienPathDirectory = Application.StartupPath + @"\AnhDaiDien";
            anhDaiDienPathFile = anhDaiDienPathDirectory + @"\avatar.png";
            studentPathFile = Application.StartupPath + @"\Data\student_data.info";
            historyPathFile = Application.StartupPath + @"\Data\historylearning_data.info";
            if (File.Exists(anhDaiDienPathFile))
            {
                FileStream fileStream = new FileStream(anhDaiDienPathFile, FileMode.Open, FileAccess.Read);
                picAnhDaiDien.Image = Image.FromStream(fileStream);
                fileStream.Close();
            }

            //var student = StudentService.GetStudent(idStudent);
            var student = StudentService.GetStudent(studentPathFile, idStudent);
            if (student == null)
            {
                throw new Exception("Lỗi rồi. Sinh viên này không tồn tại");
            }
            else
            {
                student.ListHistoryLearning = 
                    HistoryLearningService.GetListHistoryLearning(historyPathFile,idStudent);

                txtMaSinhVien.Text = student.ID;
                txtHoTen.Text = student.FullName;
                dtpNgaySinh.Value = student.DateOfBirth;
                txtNoiSinh.Text = student.PlaceOfBirth;
                chkGioiTinh.Checked = student.Gender == Model.GENDER.Male;

                dtgQuaTrinhHocTap.AutoGenerateColumns = false;
                bdsQuaTrinhHocTap.DataSource = student.ListHistoryLearning;
                dtgQuaTrinhHocTap.DataSource = bdsQuaTrinhHocTap;

                lblTongSoMuc.Text = string.Format("{0} mục", 
                    student.ListHistoryLearning.Count());
            }
        }

        private void lnkChonAnhDaiDien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "File ảnh(*.jpg, *.png)|*.png;*.jpg";
            fileDialog.Title = "Chọn ảnh đại diện";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                #region Hiển thị ảnh được chọn lên picture box
                var fileName = fileDialog.FileName;
                FileStream fileStream = new FileStream(anhDaiDienPathFile, FileMode.Open, FileAccess.Read);
                var anhDaiDien = Image.FromStream(fileStream);
                #endregion

                #region Lưu ảnh đại diện vào thư mục của chương trình
                if (!Directory.Exists(anhDaiDienPathDirectory))
                {
                    Directory.CreateDirectory(anhDaiDienPathDirectory);
                }
                anhDaiDien.Save(anhDaiDienPathFile);
                #endregion

                picAnhDaiDien.Image = anhDaiDien;
                fileStream.Close();
            }
        }

        private void picAnhDaiDien_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }

        private void picAnhDaiDien_DragDrop(object sender, DragEventArgs e)
        {
            var fileNameList = (string[])e.Data.GetData(DataFormats.FileDrop);
            FileStream fileStream = new FileStream(fileNameList.FirstOrDefault(), FileMode.Open, FileAccess.Read);
            var anhDaiDien = Image.FromStream(fileStream);

            #region Lưu ảnh đại diện vào thư mục của chương trình
            if (!Directory.Exists(anhDaiDienPathDirectory))
            {
                Directory.CreateDirectory(anhDaiDienPathDirectory);
            }
            anhDaiDien.Save(anhDaiDienPathFile);
            #endregion

            picAnhDaiDien.Image = anhDaiDien;
            fileStream.Close();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var history = bdsQuaTrinhHocTap.Current as HistoryLearning;
            if (history != null)
            {
                var resultDialog = MessageBox.Show(
                "Bạn có thực sự muốn xóa?",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
                if (resultDialog == DialogResult.OK)
                {
                    //Viết code xóa dữ liệu ở đây --> Bài tập về nhà ngày 12/10/2019
                    HistoryLearningService.Remove(historyPathFile,history);
                    bdsQuaTrinhHocTap.RemoveCurrent();
                    MessageBox.Show(
                        "Đã xóa dữ liệu thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e) 
        {
            // Sửa
            var history = bdsQuaTrinhHocTap.Current as HistoryLearning;
            if (history != null)
            {
                var resultDialog = MessageBox.Show(
                "Bạn có thực sự muốn sửa?",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
                if (resultDialog == DialogResult.OK)
                {
                    //Viết code xóa dữ liệu ở đây --> Bài tập về nhà ngày 12/10/2019
                    HistoryLearningService.Update(historyPathFile, history);
                    MessageBox.Show(
                        "Đã sửa dữ liệu thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            // Thêm
            var history = bdsQuaTrinhHocTap.Current as HistoryLearning;
            if (history != null)
            {
                var resultDialog = MessageBox.Show(
                "Bạn có thực sự muốn thêm?",
                "Thông báo",
                MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
                if (resultDialog == DialogResult.OK)
                {
                    //Viết code xóa dữ liệu ở đây --> Bài tập về nhà ngày 12/10/2019
                    HistoryLearningService.Add(historyPathFile, history);
                    MessageBox.Show(
                        "Đã thêm dữ liệu thành công!",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        }
    }
}
