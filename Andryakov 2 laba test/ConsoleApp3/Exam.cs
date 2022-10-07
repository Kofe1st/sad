using ConsoleApp3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Exam: IDateAndCopy
{
    public string item_name { get; set; }
    public int estimation { get; set; }
    public System.DateTime exam_date { get; set; }
    public DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public Exam(string item, int est, System.DateTime ed) { item_name = item; estimation = est; exam_date = ed; }
    public Exam() { item_name = "-"; estimation = 0; exam_date = DateTime.Now; }

    public override string ToString()
    {
        return item_name + " " + estimation + " " + exam_date;
    }

    public object DeepCopy()
    {
        throw new NotImplementedException();
    }
}
