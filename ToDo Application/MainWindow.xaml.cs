using System.Collections.ObjectModel;
using System.Windows;
using ToDo_Application;


namespace ToDo_Application
{
    public partial class MainWindow : Window
    {
        private ObservableCollection<TaskItem> tasks;

        public MainWindow()
        {
            InitializeComponent();
            tasks = new ObservableCollection<TaskItem>();
            TasksListBox.ItemsSource = tasks;
        }

        private void AddTaskButton_Click(object sender, RoutedEventArgs e)
        {
            string newTask = NewTaskTextBox.Text;
            if (!string.IsNullOrEmpty(newTask))
            {
                
                tasks.Add(new TaskItem { TaskDescription = newTask });
                NewTaskTextBox.Clear();
                NewTaskTextBox.Focus();
            }
            else
            {
                MessageBox.Show("Lütfen bir task giriniz.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        private void RemoveTaskButton_Click(object sender, RoutedEventArgs e)
        {
            if (TasksListBox.SelectedItem != null)
            {
                tasks.Remove((TaskItem)TasksListBox.SelectedItem);
            }
            else
            {
                MessageBox.Show("Silmek istediğiniz task seçiniz.", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

        
    }
}
