using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackedColumnGrouping
{
    public class ViewModel
    {
        public List<Model> GoogleDrive { get; set; }
        public List<Model> OneDrive {  get; set; }
        public List<Model> GoogleMeet { get; set; }
        public List<Model> Teams { get; set; }
       
        public ViewModel() 
        { 
            GoogleDrive = new List<Model>();
            GoogleDrive.Add(new Model() {Month="Jan", Value=17 });
            GoogleDrive.Add(new Model() { Month = "Feb", Value = 12 });
            GoogleDrive.Add(new Model() { Month = "Mar", Value = 15 });
            GoogleDrive.Add(new Model() { Month = "Apr", Value = 12 });
            GoogleDrive.Add(new Model() { Month = "May", Value = 10 });

            OneDrive = new List<Model>();
            OneDrive.Add(new Model() { Month = "Jan", Value = 11 });
            OneDrive.Add(new Model() { Month = "Feb", Value = 17 });
            OneDrive.Add(new Model() { Month = "Mar", Value = 9 });
            OneDrive.Add(new Model() { Month = "Apr", Value = 13 });
            OneDrive.Add(new Model() { Month = "May", Value = 8 });

            GoogleMeet = new List<Model>();
            GoogleMeet.Add(new Model() { Month = "Jan", Value = 10 });
            GoogleMeet.Add(new Model() { Month = "Feb", Value = 7 });
            GoogleMeet.Add(new Model() { Month = "Mar", Value = 5 });
            GoogleMeet.Add(new Model() { Month = "Apr", Value = 8 });
            GoogleMeet.Add(new Model() { Month = "May", Value = 12 });

            Teams = new List<Model>();
            Teams.Add(new Model() { Month = "Jan", Value = 13 });
            Teams.Add(new Model() { Month = "Feb", Value = 10 });
            Teams.Add(new Model() { Month = "Mar", Value = 8 });
            Teams.Add(new Model() { Month = "Apr", Value = 10 });
            Teams.Add(new Model() { Month = "May", Value = 5 });
        }  
    }
}
