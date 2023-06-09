using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using zadacha6.Controller;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace zadacha6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void LoadRecord(Animal animal)
        {
            txtbID.BackColor = Color.White;
            txtbID.Text = animal.Id.ToString();
            txtbName.Text = animal.Name;
            txtbAge.Text = animal.Age.ToString();
            cmbbBreed.Text = animal.Breeds.BreedName;
        }
        private void ClearScreen()
        {
            txtbID.BackColor = Color.White;
            txtbID.Clear();
            txtbName.Clear();
            txtbAge.Clear();
            cmbbBreed.Text = "";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            {
                List<Breed> allBreeds = breedController.GetAllBreeds();
                cmbbBreed.DataSource = allBreeds;
                cmbbBreed.DisplayMember = "Name";
                cmbbBreed.ValueMember = "Id";

                btnSelectAll_Click(sender, e);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private DBContext animalContext = new DBContext();
        public List<Animal> GetALL()
        {
            using (animalContext = new DBContext())
            {
                List<Animal> listAnimals = animalContext.Animals.ToList();
                return listAnimals;
            }
        }
        public Animal Get(int id)
        {
            using (animalContext = new DBContext())
            {
                Animal foundAnimal = animalContext.Animals.Find(id);
                if (foundAnimal != null)
                {
                    animalContext.Entry(foundAnimal).Reference(x => x.Breeds).Load();
                }
                return foundAnimal;
            }

        }
        public void Create(Animal animal)
        {
            using (animalContext = new DBContext())
            {
                animalContext.Animals.Add(animal);
                animalContext.SaveChanges();

            }
        }
        public void Update(int id, Animal animal)
        {
            Animal foundAnimal = animalContext.Animals.Find(id);
            if (foundAnimal == null)
            {
                return;
            }
            foundAnimal.Age = animal.Age;
            foundAnimal.Name = animal.Name;
            foundAnimal.BreedsId = animal.BreedsId;
            animalContext.SaveChanges();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
        public void Delete(int id)
        {
            Animal foundAimal = animalContext.Animals.Find(id);
            animalContext.Animals.Remove(foundAimal);
            animalContext.SaveChanges();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            AnimalLogic animalController = new AnimalLogic();
            //Ако няма намерен и визуализиран запис на екрана!!!
            if (string.IsNullOrEmpty(txtbID.Text) || txtbID.Text == "")
            {
                MessageBox.Show("Въведете данни!");
                txtbID.Focus();
                return;
            }
            Animal newAnimal = new Animal();
            newAnimal.Age = int.Parse(textBox3.Text);
            newAnimal.Name = textBox2.Text;
            //записва в таблицата Id на избрания елемент =>
            //Разлиства имената на породите, а записва съответното Id
            newAnimal.BreedId = (int)comboBox1.SelectedValue;

            animalController.Create(newAnimal);
            MessageBox.Show("Записът е успешно добавен!");
            ClearScreen();
            btnSelectAll_Click(sender, e);

        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {


        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            {
                int findId = 0;
                if (string.IsNullOrEmpty(txtbID.Text) || !txtbID.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Въведете Id за търсене!");
                    txtbID.BackColor = Color.Red;
                    txtbID.Focus();
                    return;
                }
                else
                {
                    findId = int.Parse(txtbID.Text);
                }
                Animal foundAnimal = AnimalLogic.Get(findId);
                if (foundAnimal == null)
                {
                    MessageBox.Show("НЯМА ТАКЪВ ЗАПИС в БД! \n Въведете Id за търсене!");
                    txtbID.BackColor = Color.Red;
                    txtbID.Focus();
                    return;
                }
                LoadRecord(foundAnimal);
            }
        }
    }
}
