using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advocaciaPrincipal.Models
{
    public class Advogado
    {

        public int codigo { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public char sexo { get; set; }




        public bool verificarseadvogadomaiordeidade()
        {
            if (this.idade>= 18)
            {
                return true;

                
            }
            else
            {

                return false;
            }

            
        }
        public List<Advogado> getalladvogados()
        {
            return null;



        }
        public bool eExperiente()
        {

            return false;
        }   





































    }
}
