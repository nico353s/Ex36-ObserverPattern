using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ex36_ObserverPattern
{
    public class Academy : IAcademy
    {
        private List<IStudent> students = new List<IStudent>();
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
                Notify();
            }
        }

        public Academy(string name, string adress)
        {
            
           
        }

        public void Attach(IStudent s)
        {
            students.Add(s);
        }

        public void Detach(IStudent s)
        {
            students.Remove(s);
        }

        public void Notify()
        {

            foreach (IStudent student in students)
            {
                student.Update();

            }
        }

    }
}
