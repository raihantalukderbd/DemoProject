using DemoProject.helper;
using System;
using System.Linq;
using System.Windows.Forms;

namespace DemoProject
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();

            this.comBoGender.DataSource = Enum.GetValues(typeof(EnumCollection.GenderEnums))
                .Cast<EnumCollection.GenderEnums>().Select(v => new
                {
                    Name = v.ToString(),
                    Value = v
                }).ToList();
            this.comBoGender.DisplayMember = "Name";
            this.comBoGender.ValueMember = "Value";

            this.comboBloodGroup.DataSource = EnumHelper.ToKeyPairList<EnumCollection.BloodGroupEnum>();

            this.comboBloodGroup.DisplayMember = "Value";
            this.comboBloodGroup.ValueMember = "Id";
        }
    }
}
