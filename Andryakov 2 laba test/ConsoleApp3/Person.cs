using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    public class Person: IDateAndCopy
    {
        protected private string name;
        protected private string surname;
        protected private System.DateTime date_of_birth;

        public Person(string n, string sn, System.DateTime dob) { name = n; surname = sn; date_of_birth = dob; }
        public Person() { name = "-"; surname = "-"; date_of_birth = DateTime.Now; }

        public string Name { get { return name; } }
        public string Surname { get { return surname; } }
        public System.DateTime DOB { get { return date_of_birth; } }
        public int IntDoB { get { return Convert.ToInt32(date_of_birth); } set { date_of_birth = Convert.ToDateTime(value); } } //без понятия почему не запускает

        public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string ToString()
        {
            return "Имя: " + name + " Фамилия: " + surname + " Дата рождения: " + date_of_birth.ToString();
        }

        public virtual string ToShortString()
        {
            return "Имя: " + name + " Фамилия: " + surname;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;

            Person person = (Person)obj;
            return ((this.name == person.name) && (this.surname == person.surname) && (this.date_of_birth  == person.date_of_birth));
        }
        public static bool operator ==(Person c1, Object obj)
        {
            return (c1.Equals(obj));
        }
        public static bool operator !=(Person c1, Object obj)
        {
            return (!c1.Equals(obj));
        }

        public virtual Object DeepCopy()
        {
            return (new Person(this.name, this.surname, this.date_of_birth));
        }

        public override int GetHashCode()
        {
            var hashCode = 690581101;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(surname);
            hashCode = hashCode * -1521134295 + date_of_birth.GetHashCode();
            hashCode = hashCode * -1521134295 + IntDoB.GetHashCode();
            return hashCode;
        }

    }
}
