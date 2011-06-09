using System;
using System.Windows;

namespace XeDotNet.SimpleTodo
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            MainWindow main = new MainWindow();
            //TodoListView view = new TodoListView();
            //TodoListViewModel viewModel = new TodoListViewModel(view, new TodoListFakeService());
            //viewModel.Initialize();
            //main.AddChild(view);

            Application app = new Application();
            app.Run(main);
        }
    }
}