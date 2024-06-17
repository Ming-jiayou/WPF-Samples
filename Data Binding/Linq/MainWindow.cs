// // Copyright (c) Microsoft. All rights reserved.
// // Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Linq
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Tasks tasks = new Tasks();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var pri = ((sender as ListBox).SelectedItem as ListBoxItem).Content.ToString();
            TaskType type = new TaskType();
            switch (pri)
            {
                case "Home":
                    type = TaskType.Home;
                    break;
                case "Work":
                    type = TaskType.Work;
                    break;
                default:
                    break;
            }
            
            DataContext = tasks.Where(x => x.TaskType == type);
        }
    }
}