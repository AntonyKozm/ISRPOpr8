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

namespace ISRPOpr7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_from_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    tb_from.Text = fbd.SelectedPath;
            }
        }

        private void bt_to_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();
                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    tb_to.Text = fbd.SelectedPath;
            }
        }

        private void bt_encrypt_Click(object sender, EventArgs e)
        {
            int[] key = RSA.GetKeys(Convert.ToInt32(tb_num1.Text), Convert.ToInt32(tb_num2.Text))[0];

            string output_directory = tb_to.Text + "\\" + tb_from.Text.Split('\\').Last() + "_crypted";
            if (Directory.Exists(output_directory))
                Directory.Delete(output_directory);

            Directory.CreateDirectory(output_directory);

            foreach (string filepath in Directory.GetFiles(tb_from.Text))
            {
                byte[] bytes = File.ReadAllBytes(filepath);
                byte[] result = RSA.Encrypt(bytes, key);

                string[] filename_splitted = Path.GetFileName(filepath).Split('.');
                string output_filename = output_directory + "\\" + filename_splitted[0] + "_enc." + filename_splitted[1];

                var file = File.Create(output_filename);
                file.Close();

                File.WriteAllBytes(output_filename, result);
            }
        }

        private void bt_decrypt_Click(object sender, EventArgs e)
        {
            int[] key = RSA.GetKeys(Convert.ToInt32(tb_num1.Text), Convert.ToInt32(tb_num2.Text))[1];

            string output_directory = tb_to.Text + "\\" + tb_from.Text.Split('\\').Last() + "_decrypted";
            if (Directory.Exists(output_directory))
                Directory.Delete(output_directory);

            Directory.CreateDirectory(output_directory);

            foreach (string filepath in Directory.GetFiles(tb_from.Text))
            {
                byte[] bytes = File.ReadAllBytes(filepath);
                byte[] result = RSA.Decrypt(bytes, key);

                string[] filename_splitted = Path.GetFileName(filepath).Split('.');
                string output_filename = output_directory + "\\" + filename_splitted[0] + "_dec." + filename_splitted[1];

                var file = File.Create(output_filename);
                file.Close();

                File.WriteAllBytes(output_filename, result);
            }
        }
    }
}
