using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex36_ObserverPattern
{
    public class Student : IStudent
    {
       

        private IAcademy academy;
        private string _message;
        public string Message
        {
            get
            {
                return _message;
            }
            set
            {
                _message = value; 
            }
        }
        

        public Student(IAcademy academy, string name)
        {
            this.academy = academy;
            
        }
        public void Update()
        {
            _message = ((Academy)academy).Message;
            Console.WriteLine($"{_name} modtog nyheden {_message} fra akademiet {}");
        }
    }
}
