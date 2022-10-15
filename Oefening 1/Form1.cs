using System.Collections.Generic;
namespace Oefening_1
{
    public partial class l_int : Form
    {

        Stapel<int> stapelInt = new Stapel<int>();
        Stapel<string> stapelString = new Stapel<string>();
        Stapel<Persoon> stapelPersoon = new Stapel<Persoon>();
        public l_int()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void b_add_int_Click(object sender, EventArgs e)
        {
            stapelInt.addItem(int.Parse(tb_int.Text));
        }

        private void b_remove_int_Click(object sender, EventArgs e)
        {
            stapelInt.deleteItem();
        }

        private void b_deleteList_int_Click(object sender, EventArgs e)
        {
            stapelInt.removeList();
        }

        private void b_toString_int_Click(object sender, EventArgs e)
        {
            tb_toString_int.Text = stapelInt.ToString();
        }

        private void b_isPresent_int_Click(object sender, EventArgs e)
        {
           tb_toString_int.Text = stapelInt.isPresent(int.Parse(tb_int.Text)).ToString();
        }

        private void b_makeCopy_int_Click(object sender, EventArgs e)
        {
            Stapel<int> newStapelInt = new Stapel<int>();
            newStapelInt = stapelInt.stapelCopy();
        }

        private void b_add_string_Click(object sender, EventArgs e)
        {
            stapelString.addItem(tb_string.Text);
        }

        private void b_remove_string_Click(object sender, EventArgs e)
        {
            stapelString.deleteItem();
        }

        private void b_deleteList_string_Click(object sender, EventArgs e)
        {
            stapelString.removeList();
        }

        private void b_toString_string_Click(object sender, EventArgs e)
        {
            tb_toString_string.Text = stapelString.ToString();
        }

        private void b_isPresent_string_Click(object sender, EventArgs e)
        {
            tb_toString_string.Text = stapelString.isPresent(tb_string.Text).ToString();
        }

        private void b_makeCopy_string_Click(object sender, EventArgs e)
        {
            Stapel<string> newStapelString = new Stapel<string>();
            newStapelString = stapelString.stapelCopy();
        }

        private void b_add_person_Click(object sender, EventArgs e)
        {
            stapelPersoon.addItem(new Persoon(tb_person.Text));
        }

        private void b_remove_person_Click(object sender, EventArgs e)
        {
            stapelPersoon.deleteItem();
        }

        private void b_toString_person_Click(object sender, EventArgs e)
        {
            tb_toString_person.Text = stapelPersoon.ToString();
        }

        private void tb_deleteList_person_Click(object sender, EventArgs e)
        {
            stapelPersoon.removeList();
        }

        private void b_isPresent_person_Click(object sender, EventArgs e)
        {
            Persoon persoon = new Persoon(tb_person.Text);
            tb_toString_person.Text = stapelPersoon.isPresent(persoon).ToString();
        }

        private void b_makeCopy_person_Click(object sender, EventArgs e)
        {
            Stapel<Persoon> newStapelPërsoon = new Stapel<Persoon>();
            newStapelPërsoon = stapelPersoon.stapelCopy();

        }
    }
}