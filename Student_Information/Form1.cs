using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Information
{
    public partial class Form1 : Form
    {
        int index;
        string sex = "", skills = "";
        byte[] img;
        public Form1()
        {
            InitializeComponent();
            //declaring all column names for text fields
            dgvStudents.ColumnCount = 31;
            dgvStudents.Columns[0].Name = "Student Number";
            dgvStudents.Columns[1].Name = "Year Level";
            dgvStudents.Columns[2].Name = "Course";
            dgvStudents.Columns[3].Name = "First Name";
            dgvStudents.Columns[4].Name = "Last Name";
            dgvStudents.Columns[5].Name = "Middle Name";
            dgvStudents.Columns[6].Name = "Extension Name";
            dgvStudents.Columns[7].Name = "Sex";
            dgvStudents.Columns[8].Name = "Civil Status";
            dgvStudents.Columns[9].Name = "Citizenship";
            dgvStudents.Columns[10].Name = "Date of Birth";
            dgvStudents.Columns[11].Name = "Place of Birth";
            dgvStudents.Columns[12].Name = "Age";
            dgvStudents.Columns[13].Name = "Mobile Number";
            dgvStudents.Columns[14].Name = "Email Address";
            dgvStudents.Columns[15].Name = "Barangay/Street";
            dgvStudents.Columns[16].Name = "City";
            dgvStudents.Columns[17].Name = "Province";
            dgvStudents.Columns[18].Name = "District";
            dgvStudents.Columns[19].Name = "Zip Code";
            dgvStudents.Columns[20].Name = "DSWD Household Number";
            dgvStudents.Columns[21].Name = "Household Income per Capital";
            dgvStudents.Columns[22].Name = "Father's First Name";
            dgvStudents.Columns[23].Name = "Father's Last Name";
            dgvStudents.Columns[24].Name = "Father's Extension Name";
            dgvStudents.Columns[25].Name = "Father's Occupation";
            dgvStudents.Columns[26].Name = "Mother's First Name";
            dgvStudents.Columns[27].Name = "Mother's Last Name";
            dgvStudents.Columns[28].Name = "Mother's Extension Name";
            dgvStudents.Columns[29].Name = "Mother's Occupation";
            dgvStudents.Columns[30].Name = "Skills";

        }

        public void ClearText()
        {
            txtStudentNumber.Clear();
            cmbYearLvl.SelectedIndex = 0;
            cmbCourse.SelectedIndex = 0;
            txtFname.Clear();
            txtLname.Clear();
            txtMName.Clear();
            txtEname.Clear();
            txtCivilStat.Clear();
            txtCitizenship.Clear();
            dtpBirthday.ResetText();
            txtPlaceOfBirth.Clear();
            numAge.Value = 15;
            txtMobileNum.Clear();
            txtEmailAdd.Clear();
            txtBarangay.Clear();
            txtCity.Clear();
            txtProvince.Clear();
            txtDistrict.Clear();
            txtZipCode.Clear();
            txtHouseholdNum.Clear();
            txtHCI.Clear();
            txtFathersFname.Clear();
            txtFathersLname.Clear();
            txtFEName.Clear();
            txtFOccupation.Clear();
            txtMothersFname.Clear();
            txtMothersLname.Clear();
            txtMEName.Clear();
            txtMOccupation.Clear();
            PicImage.Image = null;
            rbMale.Checked = false;
            rbFemale.Checked = false;
            cbCpp.Checked = false;
            cbCsharp.Checked = false;
            cbJava.Checked = false;
            cbPhp.Checked = false;
            cbPython.Checked = false;
            cbVbNet.Checked = false;

        }
        public void RadioButtons()
        {
            if (rbMale.Checked)
                sex = "Male";
            else if (rbFemale.Checked)
                sex = "Female";
            if (cbCpp.Checked)
                skills += "C++";
            if (cbCsharp.Checked)
                skills += "C#";
            if (cbJava.Checked)
                skills += "JAVA";
            if (cbPython.Checked)
                skills += "Python";
            if (cbVbNet.Checked)
                skills += "VB.NET";


        }
        public void CheckBox()
        {
            if (cbCpp.Checked)
                skills += "C++";
            if (cbCsharp.Checked)
                skills += "C#";
            if (cbJava.Checked)
                skills += "JAVA";
            if (cbPython.Checked)
                skills += "Python";
            if (cbVbNet.Checked)
                skills += "VB.NET";
        }
        public void PicBox()
        {
            MemoryStream ms = new MemoryStream();
            PicImage.Image.Save(ms, PicImage.Image.RawFormat); 
            img = ms.ToArray();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dgvStudents.Rows[index];
            txtStudentNumber.Text = row.Cells[0].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sex = " ", skills = " ";

            if (rbMale.Checked)
                sex = "Male";
            else if (rbFemale.Checked)
                sex = "Female";

            if (cbCpp.Checked)
                skills += "C++";
            if (cbCsharp.Checked)
                skills += "C#";
            if (cbPhp.Checked)
                skills += "Php";
            if (cbJava.Checked)
                skills += "Java";
            if (cbVbNet.Checked)
                skills += "VB.Net";
            if (cbPython.Checked)
                skills += "Python";

            MemoryStream ms = new MemoryStream();
            PicImage.Image.Save(ms, PicImage.Image.RawFormat);
            byte[] img = ms.ToArray();

            dgvStudents.Rows.Add(txtStudentNumber.Text, cmbYearLvl.SelectedItem, cmbCourse.SelectedItem, txtFname.Text, txtLname.Text, txtMName.Text, txtEname.Text, sex,
                                    txtCivilStat.Text, txtCitizenship.Text, dtpBirthday.Value, txtPlaceOfBirth.Text, numAge.Value, txtMobileNum.Text, txtEmailAdd.Text, txtBarangay.Text,
                                    txtCity.Text, txtProvince.Text, txtDistrict.Text, txtZipCode.Text, txtHouseholdNum.Text, txtHCI.Text, txtFathersFname.Text, txtFathersLname.Text, txtFEName.Text,
                                    txtFOccupation.Text, txtMothersFname.Text, txtMothersLname.Text, txtMEName.Text, txtMOccupation.Text, skills, img);
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Choose image (*.jpg; *.png; *.gif;) | *.jpg; *.png; *.gif;";

            if (openfile.ShowDialog() == DialogResult.OK)
                PicImage.Image = Image.FromFile(openfile.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewImageColumn dgvImage = new DataGridViewImageColumn();
            dgvImage.HeaderText = "Image";
            dgvImage.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dgvStudents.Columns.Add(dgvImage);
        }

        private void txtStudentNumber_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStudentNumber.Text))
            {
                e.Cancel = true;
                txtStudentNumber.Focus();
                errorProvider1.SetError(txtStudentNumber, "Student number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtStudentNumber, "");
            }
        }

        private void txtStudentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFname.Text))
            {
                e.Cancel = true;
                txtFname.Focus();
                errorProvider1.SetError(txtFname, "First name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFname, "");
            }
        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLname.Text))
            {
                e.Cancel = true;
                txtLname.Focus();
                errorProvider1.SetError(txtLname, "Last name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLname, "");
            }
        }

        private void txtLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMName.Text))
            {
                e.Cancel = true;
                txtMName.Focus();
                errorProvider1.SetError(txtMName, "Student number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMName, "");
            }
        }

        private void txtMName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEname.Text))
            {
                e.Cancel = true;
                txtEname.Focus();
                errorProvider1.SetError(txtEname, "Extension name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtEname, "");
            }
        }

        private void txtEname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCivilStat_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCivilStat.Text))
            {
                e.Cancel = true;
                txtCivilStat.Focus();
                errorProvider1.SetError(txtCivilStat, "Civil status should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCivilStat, "");
            }
        }

        private void txtCivilStat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCitizenship_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCitizenship.Text))
            {
                e.Cancel = true;
                txtCitizenship.Focus();
                errorProvider1.SetError(txtCitizenship, "Citizenship should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCitizenship, "");
            }
        }

        private void txtCitizenship_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPlaceOfBirth_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlaceOfBirth.Text))
            {
                e.Cancel = true;
                txtPlaceOfBirth.Focus();
                errorProvider1.SetError(txtPlaceOfBirth, "Birth place should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPlaceOfBirth, "");
            }
        }

        private void txtPlaceOfBirth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMobileNum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMobileNum.Text))
            {
                e.Cancel = true;
                txtMobileNum.Focus();
                errorProvider1.SetError(txtMobileNum, "Mobile number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMobileNum, "");
            }
        }

        private void txtMobileNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtBarangay_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBarangay.Text))
            {
                e.Cancel = true;
                txtBarangay.Focus();
                errorProvider1.SetError(txtBarangay, "Barangay or Street should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBarangay, "");
            }
        }

        private void txtBarangay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                e.Cancel = true;
                txtCity.Focus();
                errorProvider1.SetError(txtCity, "City should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtCity, "");
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtProvince_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProvince.Text))
            {
                e.Cancel = true;
                txtProvince.Focus();
                errorProvider1.SetError(txtProvince, "Province should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtProvince, "");
            }
        }

        private void txtProvince_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtDistrict_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDistrict.Text))
            {
                e.Cancel = true;
                txtDistrict.Focus();
                errorProvider1.SetError(txtDistrict, "Zip code should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDistrict, "");
            }
        }

        private void txtDistrict_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtZipCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtZipCode.Text))
            {
                e.Cancel = true;
                txtZipCode.Focus();
                errorProvider1.SetError(txtZipCode, "Zip code should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtZipCode, "");
            }
        }

        private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHouseholdNum_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHouseholdNum.Text))
            {
                e.Cancel = true;
                txtHouseholdNum.Focus();
                errorProvider1.SetError(txtHouseholdNum, "House number should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtHouseholdNum, "");
            }
        }

        private void txtHouseholdNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtHCI_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtHCI.Text))
            {
                e.Cancel = true;
                txtHCI.Focus();
                errorProvider1.SetError(txtHCI, "Capital should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtHCI, "");
            }
        }

        private void txtHCI_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFathersFname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFathersFname.Text))
            {
                e.Cancel = true;
                txtFathersFname.Focus();
                errorProvider1.SetError(txtFathersFname, "Father's first name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFathersFname, "");
            }
        }

        private void txtFathersFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFathersLname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFathersLname.Text))
            {
                e.Cancel = true;
                txtFathersLname.Focus();
                errorProvider1.SetError(txtFathersLname, "Father's last name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFathersLname, "");
            }
        }

        private void txtFathersLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFEName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFEName.Text))
            {
                e.Cancel = true;
                txtFEName.Focus();
                errorProvider1.SetError(txtFEName, "Father's extension name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFEName, "");
            }
        }

        private void txtFEName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtFOccupation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFOccupation.Text))
            {
                e.Cancel = true;
                txtFOccupation.Focus();
                errorProvider1.SetError(txtFOccupation, "Father's occupation should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFOccupation, "");
            }
        }

        private void txtFOccupation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMothersFname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMothersFname.Text))
            {
                e.Cancel = true;
                txtMothersFname.Focus();
                errorProvider1.SetError(txtMothersFname, "Mother's first name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMothersFname, "");
            }
        }

        private void txtMothersFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMothersLname_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMothersLname.Text))
            {
                e.Cancel = true;
                txtMothersLname.Focus();
                errorProvider1.SetError(txtMothersLname, "Mother's last name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMothersLname, "");
            }
        }

        private void txtMothersLname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMEName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMEName.Text))
            {
                e.Cancel = true;
                txtMEName.Focus();
                errorProvider1.SetError(txtMEName, "Mother's extension name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMEName, "");
            }
        }

        private void txtMEName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMOccupation_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMOccupation.Text))
            {
                e.Cancel = true;
                txtMOccupation.Focus();
                errorProvider1.SetError(txtMOccupation, "Mother's occupation should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMOccupation, "");
            }
        }

        private void txtMOccupation_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
          
                string message = "Do you want to abort this operation ?";
            string title = "Student Info!";

            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
                if (result == DialogResult.Abort) {
                this.Close();
                    
            }
            else if (result == DialogResult.Retry){
                // Do nothing
            }
            else {
                
            }
                if (MessageBox.Show("Do you want to update this record?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RadioButtons();
                CheckBox();
                PicBox();
                DataGridViewRow row2 = dgvStudents.Rows[index];
                row2.Cells[0].Value = txtStudentNumber.Text;
                row2.Cells[1].Value = cmbYearLvl.SelectedItem;
                row2.Cells[2].Value = cmbCourse.SelectedItem;
                row2.Cells[3].Value = txtFname.Text; 
                row2.Cells[4].Value = txtLname.Text;
                row2.Cells[5].Value = txtMName.Text;
                row2.Cells[6].Value = txtEname.Text;
                row2.Cells[7].Value = txtCivilStat.Text;
                row2.Cells[8].Value = txtCitizenship.Text;
                row2.Cells[9].Value = dtpBirthday.Value;
                row2.Cells[10].Value = txtPlaceOfBirth.Text;
                row2.Cells[11].Value = numAge.Value;
                row2.Cells[12].Value = txtMobileNum.Text;
                row2.Cells[13].Value = txtEmailAdd.Text;
                row2.Cells[14].Value = txtBarangay.Text;
                row2.Cells[15].Value = txtCity.Text;
                row2.Cells[11].Value = txtProvince.Text;
                row2.Cells[12].Value = txtDistrict.Text;
                row2.Cells[13].Value = txtZipCode.Text;
                row2.Cells[14].Value = txtHouseholdNum.Text;
                row2.Cells[15].Value = txtHCI.Text;
                row2.Cells[16].Value = txtFathersFname.Text;
                row2.Cells[17].Value = txtFathersLname.Text;
                row2.Cells[18].Value = txtFEName.Text;
                row2.Cells[19].Value = txtFOccupation.Text;
                row2.Cells[20].Value = txtMothersFname.Text;
                row2.Cells[21].Value = txtMothersLname.Text;
                row2.Cells[22].Value = txtMEName.Text;
                row2.Cells[23].Value = txtMOccupation.Text;
                row2.Cells[24].Value = img;
               }
                else
            {
                MessageBox.Show("Record not Updated ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this record?", "Warning", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow row3 = dgvStudents.Rows[index];
                dgvStudents.Rows.RemoveAt(row3.Index);

            }
            else
            {
                MessageBox.Show("Record not deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Filter = "Choose image (*.jpg; *.png; *.gif;) | *.jpg; *.png; *.gif;";

            if (openfile.ShowDialog() == DialogResult.OK)
                PicImage.Image = Image.FromFile(openfile.FileName);
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this record?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DataGridViewRow row3 = dgvStudents.Rows[index];
                dgvStudents.Rows.RemoveAt(row3.Index);

            }
            else
            {
                MessageBox.Show("Record not deleted", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            ClearText();
            cmbCourse.ResetText();
            cmbYearLvl.ResetText();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            string sex = " ", skills = " ";

            if (rbMale.Checked)
                sex = "Male";
            else if (rbFemale.Checked)
                sex = "Female";

            if (cbCpp.Checked)
                skills += "C++";
            if (cbCsharp.Checked)
                skills += "C#";
            if (cbPhp.Checked)
                skills += "Php";
            if (cbJava.Checked)
                skills += "Java";
            if (cbVbNet.Checked)
                skills += "VB.Net";
            if (cbPython.Checked)
                skills += "Python";

            MemoryStream ms = new MemoryStream();
            PicImage.Image.Save(ms, PicImage.Image.RawFormat);
            byte[] img = ms.ToArray();

            dgvStudents.Rows.Add(txtStudentNumber.Text, cmbYearLvl.SelectedItem, cmbCourse.SelectedItem, txtFname.Text, txtLname.Text, txtMName.Text, txtEname.Text, sex,
                                    txtCivilStat.Text, txtCitizenship.Text, dtpBirthday.Value, txtPlaceOfBirth.Text, numAge.Value, txtMobileNum.Text, txtEmailAdd.Text, txtBarangay.Text,
                                    txtCity.Text, txtProvince.Text, txtDistrict.Text, txtZipCode.Text, txtHouseholdNum.Text, txtHCI.Text, txtFathersFname.Text, txtFathersLname.Text, txtFEName.Text,
                                    txtFOccupation.Text, txtMothersFname.Text, txtMothersLname.Text, txtMEName.Text, txtMOccupation.Text, skills, img);
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {

            string message = "Do you want to abort this operation ?";
            string title = "Student Info!";

            MessageBoxButtons buttons = MessageBoxButtons.AbortRetryIgnore;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Abort)
            {
                this.Close();

            }
            else if (result == DialogResult.Retry)
            {
                // Do nothing
            }
            else
            {

            }
            if (MessageBox.Show("Do you want to update this record?", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RadioButtons();
                CheckBox();
                PicBox();
                DataGridViewRow row2 = dgvStudents.Rows[index];
                row2.Cells[0].Value = txtStudentNumber.Text;
                row2.Cells[1].Value = cmbYearLvl.SelectedItem;
                row2.Cells[2].Value = cmbCourse.SelectedItem;
                row2.Cells[3].Value = txtFname.Text;
                row2.Cells[4].Value = txtLname.Text;
                row2.Cells[5].Value = txtMName.Text;
                row2.Cells[6].Value = txtEname.Text;
                row2.Cells[7].Value = txtCivilStat.Text;
                row2.Cells[8].Value = txtCitizenship.Text;
                row2.Cells[9].Value = dtpBirthday.Value;
                row2.Cells[10].Value = txtPlaceOfBirth.Text;
                row2.Cells[11].Value = numAge.Value;
                row2.Cells[12].Value = txtMobileNum.Text;
                row2.Cells[13].Value = txtEmailAdd.Text;
                row2.Cells[14].Value = txtBarangay.Text;
                row2.Cells[15].Value = txtCity.Text;
                row2.Cells[11].Value = txtProvince.Text;
                row2.Cells[12].Value = txtDistrict.Text;
                row2.Cells[13].Value = txtZipCode.Text;
                row2.Cells[14].Value = txtHouseholdNum.Text;
                row2.Cells[15].Value = txtHCI.Text;
                row2.Cells[16].Value = txtFathersFname.Text;
                row2.Cells[17].Value = txtFathersLname.Text;
                row2.Cells[18].Value = txtFEName.Text;
                row2.Cells[19].Value = txtFOccupation.Text;
                row2.Cells[20].Value = txtMothersFname.Text;
                row2.Cells[21].Value = txtMothersLname.Text;
                row2.Cells[22].Value = txtMEName.Text;
                row2.Cells[23].Value = txtMOccupation.Text;
                row2.Cells[24].Value = img;
            }
            else
            {
                MessageBox.Show("Record not Updated ", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearText();
            cmbCourse.ResetText();
            cmbYearLvl.ResetText();
        }
    }
}

