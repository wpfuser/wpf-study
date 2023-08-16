using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp01_ListBox
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }

    public class Student
    {
        public string Name { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
    }
    public class Students : ObservableCollection<Student>
    {
        public Students()
        {
            Add(new Student() { Name = "张三", Age = 19, City = "北海", Sex = "男" });
            Add(new Student() { Name = "李四", Age = 29, City = "深圳", Sex = "男" });
            Add(new Student() { Name = "王五", Age = 39, City = "山东", Sex = "男" });
            Add(new Student() { Name = "张龙", Age = 49, City = "福建", Sex = "男" });
            Add(new Student() { Name = "赵虎", Age = 59, City = "浙江", Sex = "男" });
            Add(new Student() { Name = "王朝", Age = 69, City = "新疆维吾尔自治区", Sex = "男" });
            Add(new Student() { Name = "马汉", Age = 79, City = "广西壮族自治区", Sex = "男" });
        }
    }
}
