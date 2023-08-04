using NotesApp3;
using System.Data;
using System.Windows.Forms;

namespace NotesApp3
{
    public partial class Form1 : Form
    {
        private Number selectedNumber = null;
        public Form1()
        {
            InitializeComponent();
            Refresh();

        }

        public void Refresh()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = DataStore.Numbers;
            //listBox1.DisplayMember = "Description";
            listBox1.DisplayMember = "Definition";
            listBox1.ValueMember = "Id";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtPerson.Text) && !string.IsNullOrEmpty(txtNumber.Text) && !string.IsNullOrEmpty(txtNote.Text))
            {
                var addedNumber = new Number();
                //addedNumber.Description = txtPerson.Text;
                addedNumber.Definition = txtPerson.Text + " - " + txtNumber.Text + " - " + txtNote.Text;

                
                if (DataStore.Numbers.Count > 0)
                {
                    addedNumber.Id = DataStore.Numbers.Max(n => n.Id) + 1;
                }
                else
                {
                    addedNumber.Id = 1;
                }

                DataStore.Numbers.Add(addedNumber);
                Refresh();

                txtPerson.Clear();
                txtNumber.Clear();
                txtNote.Clear();
            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                selectedNumber = (Number)listBox1.SelectedItem;

                
                string[] parts = selectedNumber.Definition.Split('-');

                if (parts.Length >= 3)
                {
                    txtPerson.Text = parts[0].Trim();
                    txtNumber.Text = parts[1].Trim();
                    txtNote.Text = parts[2].Trim();
                }
                else if (parts.Length >= 2)
                {
                    txtPerson.Text = parts[0].Trim();
                    txtNumber.Text = parts[1].Trim();
                    txtNote.Text = "";
                }
                else
                {
                    txtPerson.Text = selectedNumber.Definition.Trim();
                    txtNumber.Text = "";
                    txtNote.Text = "";
                }


            }



        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataStore.Numbers.Remove(selectedNumber);
            selectedNumber = null;
            txtPerson.Text = string.Empty;
            txtNumber.Text = string.Empty;
            txtNote.Text = string.Empty;
            Refresh();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPerson.Text) && !string.IsNullOrEmpty(txtNumber.Text) && !string.IsNullOrEmpty(txtNote.Text))
            {
                selectedNumber.Definition = txtPerson.Text + " - " + txtNumber.Text + " - " + txtNote.Text;
                Refresh();
            }
            else
            {
                MessageBox.Show("Tüm alanlarý doldurun.");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPerson.Clear();
            txtNumber.Clear();
            txtNote.Clear();
        }
    }
}





















































//if (!string.IsNullOrEmpty(txtPerson.Text) && !string.IsNullOrEmpty(txtNumber.Text) && !string.IsNullOrEmpty(txtNote.Text))
//{
//    var addedNumber = new Number();
//    addedNumber.Description = txtPerson.Text;
//    addedNumber.Definition = txtNumber.Text + " - " + txtNote.Text;

//    // Yeni Id hesaplamasýný optimize etmek için:
//    if (DataStore.Numbers.Count > 0)
//    {
//        addedNumber.Id = DataStore.Numbers.Max(n => n.Id) + 1;
//    }
//    else
//    {
//        addedNumber.Id = 1;
//    }

//    DataStore.Numbers.Add(addedNumber);
//    Refresh();

//    txtPerson.Clear();
//    txtNumber.Clear();
//    txtNote.Clear();
//}





//if (listBox1.SelectedItem != null)
//{
//    selectedNumber = (Number)listBox1.SelectedItem;
//    txtNote.Text = selectedNumber.Definition;
//    txtNumber.Text = selectedNumber.Definition;
//    txtPerson.Text= selectedNumber.Definition;
//}





//if (!string.IsNullOrEmpty(txtPerson.Text) && !string.IsNullOrEmpty(txtNumber.Text) && !string.IsNullOrEmpty(txtNote.Text))
//{
//    if (!string.IsNullOrEmpty(txtPerson.Text) && !string.IsNullOrEmpty(txtNumber.Text) && !string.IsNullOrEmpty(txtNote.Text))
//    {
//        string fullInfo = txtPerson.Text + " - " + txtNumber.Text + " - " + txtNote.Text;
//        listBox1.Items.Add(fullInfo);

//        var addedNumber = new Number();
//        addedNumber.Description = txtPerson.Text;
//        addedNumber.Definition = txtNumber.Text + " - " + txtNote.Text;

//        // Yeni Id hesaplamasýný optimize etmek için:
//        if (DataStore.Numbers.Count > 0)
//        {
//            addedNumber.Id = DataStore.Numbers.Max(n => n.Id) + 1;
//        }
//        else
//        {
//            addedNumber.Id = 1;
//        }

//        DataStore.Numbers.Add(addedNumber);
//        Refresh();

//        txtPerson.Clear();
//        txtNumber.Clear();
//        txtNote.Clear();
//    }







//    txtPerson.Clear();
//    txtNumber.Clear();
//    txtNote.Clear();
//}


//string fullInfo = txtPerson.Text + " - " + txtNumber.Text + " - " + txtNote.Text;
//listBox1.Items.Add(fullInfo);



//var addedNumber = new Number();
//addedNumber.Description = txtNumber.Text;
//addedNumber.Definition = txtNote.Text;

//var lastNumbers = DataStore.Numbers[DataStore.Numbers.Count - 1];
//addedNumber.Id = lastNumbers.Id + 1;

////listBox1.Items.Add(addedNumber);

//DataStore.Numbers.Add(addedNumber);
//Refresh();

//txtPerson.Clear();
//txtNumber.Clear();
//txtNote.Clear();










//if(!string.IsNullOrEmpty(txtPerson.Text) && !string.IsNullOrEmpty(txtNumber.Text)) 
//{

//    string fullInfo = txtPerson.Text + " - " + txtNumber.Text;

//    if (!string.IsNullOrEmpty(txtNote.Text))
//    {
//        fullInfo += " - " + txtNote.Text;
//    }
//    listBox1.Items.Add(fullInfo);

//    var addedNumber = new Number();
//    addedNumber.Description = txtNumber.Text;
//    addedNumber.Definition = txtNote.Text;
//    var lastNumbers = DataStore.Numbers[DataStore.Numbers.Count - 1];
//    addedNumber.Id = lastNumbers.Id + 1;

//    DataStore.Numbers.Add(addedNumber);
//    Refresh();









// string fullInfo = txtPerson.Text + " - " + txtNumber.Text + " - " + txtNote.Text;
// listBox1.Items.Add(fullInfo);