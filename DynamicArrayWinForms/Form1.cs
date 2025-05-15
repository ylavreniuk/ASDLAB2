using System;
using System.Windows.Forms;

namespace DynamicArrayWinForms
{
    public partial class Form1 : Form
    {
        private DynamicArray array;

        public Form1()
        {
            InitializeComponent(); 
            array = new DynamicArray();
        }

        
        private void UpdateArrayDisplay()
        {
            lblArray.Text = "Масив: " + array.GetArrayAsString();
        }

        
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                int element = int.Parse(txtElement.Text);
                int index = int.Parse(txtIndex.Text);
                array.Add(element, index);
                UpdateArrayDisplay();
                lblResult.Text = "Елемент додано";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
        }

        
        private void BtnAddToEnd_Click(object sender, EventArgs e)
        {
            try
            {
                int element = int.Parse(txtElement.Text);
                array.AddToEnd(element);
                UpdateArrayDisplay();
                lblResult.Text = "Елемент додано в кінець";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
        }

        
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(txtIndex.Text);
                array.Remove(index);
                UpdateArrayDisplay();
                lblResult.Text = "Елемент видалено";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
        }

        
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                int value = int.Parse(txtSearchValue.Text);
                int index = array.FindByValue(value);
                lblResult.Text = index == -1 ? "Елемент не знайдено" : $"Елемент знайдено за індексом: {index}";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка");
            }
        }

       
        private void BtnProduct_Click(object sender, EventArgs e)
        {
            long product = array.CalculateEvenIndexedProduct();
            lblResult.Text = $"Добуток елементів з парними номерами: {product}";
            UpdateArrayDisplay();
        }

        
        private void BtnSumZeros_Click(object sender, EventArgs e)
        {
            int sum = array.CalculateSumBetweenZeros();
            lblResult.Text = $"Сума елементів між нулями: {sum}";
            UpdateArrayDisplay();
        }

       
        private void BtnSort_Click(object sender, EventArgs e)
        {
            array.SortPositiveNegative();
            UpdateArrayDisplay();
            lblResult.Text = "Масив відсортовано (додатні, потім від’ємні)";
        }
    }
}