using System;
using System.Windows.Forms;
using YYX.CSharp.Common;

namespace YYX.Test.ObjectConverter
{
    public partial class Form_ObjectConverter : Form
    {
        public Form_ObjectConverter()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            Person person = new Person() {
                Name = textBox_BeforeSerializationname.Text,
                Age = (int)numericUpDown_BeforeSerializationAge.Value
            };

            ObjectConverter<Person>.Save(person);

            person = null;
            person = ObjectConverter<Person>.Load();

            textBox_AfterSerializationName.Text = person.Name;
            numericUpDown_AfterSerializationAge.Value = person.Age;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
