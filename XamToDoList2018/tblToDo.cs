using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;

namespace XamToDoList2018
{
    public class tblToDo
    {
        [PrimaryKey, AutoIncrement] //These are attributes that define the property below it
        public int Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime Date { get; set; }
        public tblToDo()
        {
        }
    }
}