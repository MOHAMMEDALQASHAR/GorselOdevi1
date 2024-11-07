using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace GorselProgramlamaOdevi
{
    public partial class Yapilacaklar : ContentPage
    {
        ObservableCollection<Task> Tasks = new ObservableCollection<Task>();

        public Yapilacaklar()
        {
            InitializeComponent();
            TasksListView.ItemsSource = Tasks;
        }

        void OnAddTaskClicked(object sender, System.EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(NewItemEntry.Text))
            {
                Tasks.Add(new Task { Name = NewItemEntry.Text });
                NewItemEntry.Text = string.Empty;
            }
        }

        void OnDeleteClicked(object sender, System.EventArgs e)
        {
            var task = (sender as ImageButton).CommandParameter as Task;
            if (task != null)
            {
                Tasks.Remove(task);
            }
        }
    }

    public class Task
    {
        public string Name { get; set; }
        public bool IsDone { get; set; }
    }
}
