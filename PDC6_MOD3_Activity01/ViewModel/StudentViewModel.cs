using System;
using System.Collections.Generic;
using System.Text;
using PDC6_MOD3_Activity01.Model;
using Xamarin.Forms;
using System.ComponentModel;



namespace PDC6_MOD3_Activity01.ViewModel
{
    class StudentViewModel : INotifyPropertyChanged

    {
        public student StudentSet { get; set; }
        public Command SubmitEntry { get; set; }
        public string StudentCodeEntry { get; set; }
        public string StudentCodeDisplay { get; set; }

        public string StudentTitleEntry { get; set; }
        public string StudentTitleDisplay { get; set; }

        public  StudentViewModel()
        {
            SubmitEntry = new Command(() =>
            {
                StudentSet = new student
                {
                    Subjectcode = StudentCodeEntry,
                   
                };

                StudentCodeDisplay = StudentCodeEntry;
                StudentTitleDisplay = StudentTitleEntry;
                OnPropertyChanged(nameof(StudentCodeDisplay));
                OnPropertyChanged(nameof(StudentCodeEntry));
                OnPropertyChanged(nameof(StudentTitleDisplay));
                OnPropertyChanged(nameof(StudentTitleEntry));

            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
