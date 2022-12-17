using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    internal class Excel
    {
        private List<Employment> employments;

        public List<Employment> Employments
        {
            get { return employments; }
            set { employments = value; }
        }

#pragma warning disable CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        public Excel()
#pragma warning restore CS8618 // Поле, не допускающее значения NULL, должно содержать значение, отличное от NULL, при выходе из конструктора. Возможно, стоит объявить поле как допускающее значения NULL.
        {
            Employments = new List<Employment>();
        }

        public Excel(List<Employment> employments)
        {
            this.employments = employments;
        }
    }
}
