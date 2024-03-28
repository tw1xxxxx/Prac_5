using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Shop
{
    /// <summary>
    /// Логика взаимодействия для admin.xaml
    /// </summary>
    public partial class admin : Window
    {
        dataBaseP8Entities bd = new dataBaseP8Entities();
        public admin()
        {
            dataBaseP8Entities bd = new dataBaseP8Entities();
            InitializeComponent();
            peopleDataGrid.ItemsSource = bd.Custumers.ToList();
            rolesDataGrid.ItemsSource = bd.Posts.ToList();
            postsCombaBox.Items.Add("1");
            postsCombaBox.Items.Add("2");
            postsCombaBox.Items.Add("3");
            postsCombaBox.Items.Add("4");
            postsCombaBox.Items.Add("5");
            rolesCombaBox.Items.Add("1");
            rolesCombaBox.Items.Add("2");
            rolesCombaBox.Items.Add("3");
            rolesCombaBox.Items.Add("4");
            rolesCombaBox.Items.Add("5");
        }
        private void AddButtonClick1(object sender, RoutedEventArgs e)
        {
            try
            {
                    var newCustumer = new Custumers
                    {
                        Имя = nameTXT.Text,
                        Фамилия = surnameTXT.Text,
                        Логин = loginTXT.Text,
                        Пароль = passwordTXT.Text,
                        Зарплата = int.Parse(zpTXT.Text),
                        Post_ID = int.Parse(postsCombaBox.SelectedItem.ToString()),
                        Role_ID = int.Parse(rolesCombaBox.SelectedItem.ToString())
                     
                };

                bd.Custumers.Add(newCustumer);
                bd.SaveChanges();
                peopleDataGrid.ItemsSource = bd.Custumers.ToList();
                MessageBox.Show("Продукт успешно добавлен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private void AddButtonClick2(object sender, RoutedEventArgs e)
        {
            try
            {
                var newPost = new Posts
                {
                    Должность = roleNameTXT.Text
                };

                bd.Posts.Add(newPost);
                bd.SaveChanges();
                rolesDataGrid.ItemsSource = bd.Posts.ToList();
                MessageBox.Show("Продукт успешно добавлен.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }
        private void EditButtonClick1(object sender, RoutedEventArgs e)
        {
            if (peopleDataGrid.SelectedItem != null)
            {
                var selectedCustumer = peopleDataGrid.SelectedItem as Custumers;
                selectedCustumer.Имя = nameTXT.Text;
                selectedCustumer.Фамилия = surnameTXT.Text;
                selectedCustumer.Логин = loginTXT.Text;
                selectedCustumer.Пароль = passwordTXT.Text;
                selectedCustumer.Зарплата = int.Parse(zpTXT.Text);
                selectedCustumer.Post_ID = int.Parse(postsCombaBox.SelectedItem.ToString());
                selectedCustumer.Role_ID = int.Parse(rolesCombaBox.SelectedItem.ToString());
                bd.SaveChanges();
                peopleDataGrid.Items.Refresh();
                MessageBox.Show("Продукт успешно изменен.");
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите продукт для изменения.");
            }
            
        
        }
        private void EditButtonClick2(object sender, RoutedEventArgs e)
        {
            if (rolesDataGrid.SelectedItem != null)
            {
                var selectedCustumer = rolesDataGrid.SelectedItem as Posts;
                selectedCustumer.Должность = roleNameTXT.Text;
              
        
                bd.SaveChanges();
                rolesDataGrid.Items.Refresh();
                MessageBox.Show("Продукт успешно изменен.");
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите продукт для изменения.");
            }


        }
        private void DeleteProduct_Click2(object sender, RoutedEventArgs e)
        {
            try
            {
                if (rolesDataGrid.SelectedItem != null)
                {
                    var selectedCustumer = rolesDataGrid.SelectedItem as Posts;
                    bd.Posts.Remove(selectedCustumer);
                    bd.SaveChanges();
                    rolesDataGrid.ItemsSource = bd.Posts.ToList();
                    MessageBox.Show("Продукт успешно удален.");
                }
                else
                {
                    MessageBox.Show("Пожалуйста, выберите продукт для удаления.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DeleteProduct_Click1(object sender, RoutedEventArgs e)
        {
            try {
            if (peopleDataGrid.SelectedItem != null)
            {
                var selectedCustumer = peopleDataGrid.SelectedItem as Custumers;
                bd.Custumers.Remove(selectedCustumer);
                bd.SaveChanges();
                peopleDataGrid.ItemsSource = bd.Custumers.ToList();
                MessageBox.Show("Продукт успешно удален.");
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите продукт для удаления.");
            } 
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
             }
        }

    }
    }

