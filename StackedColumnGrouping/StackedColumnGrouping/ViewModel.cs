using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackedColumnGrouping
{
    public class ViewModel
    {
        public List<Model> Data1 { get; set; }
        public List<Model> Data3 {  get; set; }
        public List<Model> Data2 { get; set; }
        public List<Model> Data4 { get; set; }
       
        public ViewModel() 
        { 
            Data1 = new List<Model>();
            Data1.Add(new Model() {Month="Jan", Value=17 });
            Data1.Add(new Model() { Month = "Feb", Value = 12 });
            Data1.Add(new Model() { Month = "Mar", Value = 15 });
            Data1.Add(new Model() { Month = "Apr", Value = 12 });
            Data1.Add(new Model() { Month = "May", Value = 10 });

            Data3 = new List<Model>();
            Data3.Add(new Model() { Month = "Jan", Value = 11 });
            Data3.Add(new Model() { Month = "Feb", Value = 17 });
            Data3.Add(new Model() { Month = "Mar", Value = 9 });
            Data3.Add(new Model() { Month = "Apr", Value = 13 });
            Data3.Add(new Model() { Month = "May", Value = 8 });

            Data2 = new List<Model>();
            Data2.Add(new Model() { Month = "Jan", Value = 10 });
            Data2.Add(new Model() { Month = "Feb", Value = 7 });
            Data2.Add(new Model() { Month = "Mar", Value = 5 });
            Data2.Add(new Model() { Month = "Apr", Value = 8 });
            Data2.Add(new Model() { Month = "May", Value = 12 });

            Data4 = new List<Model>();
            Data4.Add(new Model() { Month = "Jan", Value = 13 });
            Data4.Add(new Model() { Month = "Feb", Value = 10 });
            Data4.Add(new Model() { Month = "Mar", Value = 8 });
            Data4.Add(new Model() { Month = "Apr", Value = 10 });
            Data4.Add(new Model() { Month = "May", Value = 5 });
        }  
    }
}
