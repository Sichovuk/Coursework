using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_try2
{
    public partial class ApplicantForm : Form
    {
        internal Applicant TheApplicant;
        internal ApplicantForm(Applicant t)
        {
            TheApplicant = t;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            TheApplicant.FullName = tbFullName.Text.Trim();
            TheApplicant.Age = int.Parse(tbAge.Text.Trim());
            TheApplicant.PhoneNumber = tbPhoneNumber.Text.Trim();
            TheApplicant.UkrScore = double.Parse(tbUkrScore.Text.Trim());
            TheApplicant.MathScore = double.Parse(tbMathScore.Text.Trim());
            TheApplicant.HistoryScore = double.Parse(tbHistoryScore.Text.Trim());
            TheApplicant.HasPrivilege = cbHasPrivilege.Checked;
            TheApplicant.CanPay = cbCanPay.Checked;
            
            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void ApplicantForm_Load(object sender, EventArgs e)
        {
            if (TheApplicant != null)
            {
                tbFullName.Text = TheApplicant.FullName;
                tbAge.Text = TheApplicant.Age.ToString();
                tbPhoneNumber.Text = TheApplicant.PhoneNumber;
                tbUkrScore.Text = TheApplicant.UkrScore.ToString("0,0");
                tbMathScore.Text = TheApplicant.MathScore.ToString("0,0");
                tbHistoryScore.Text = TheApplicant.HistoryScore.ToString("0,0");
                cbHasPrivilege.Checked = TheApplicant.HasPrivilege;
                cbCanPay.Checked = TheApplicant.CanPay;
            }
        }
    }
}
