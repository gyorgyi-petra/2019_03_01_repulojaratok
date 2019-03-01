using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repulo
{
    public class Class1
    {

        class Jarat
        {


            public Jarat(string jaratszam, string Honnan, string Hova, DateTime Indulas)
            {
                this.jaratSzam = jaratszam;
                this.repterHonnan = Honnan;
                this.repterHova = Hova;
                this.indulas = Indulas;
               
            }


            public string jaratSzam;
            public string repterHonnan;
            public string repterHova;
            public DateTime indulas;
            public int keses;


        }

        List<Jarat> repcsik = new List<Jarat>();
        List<Jarat> indulo = new List<Jarat>();

        public void UjJarat(string jaratSzam, string repterHonnan, string repterHova, DateTime indulas) {
            var elso_jarat = new Jarat(jaratSzam,repterHonnan,repterHova,indulas);
            repcsik.Add(elso_jarat);
            Keses (jaratSzam, 0);
        }


        public void Keses(string jaratSzam, int keses) {
            for (int i = 0; i < repcsik.Count;i++) {
                if (jaratSzam.Equals(repcsik[i].jaratSzam))
                {
                    if (repcsik[i].keses + keses < 0 ) {
                        throw new NegativKesesException();
                    }
                    repcsik[i].keses += keses;
                }
            }
        }

        public DateTime MikorIndul(string jaratSzam) {
            return  DateTime.Now;
        }

     
        public List<string> JaratokRepuloterrol(string repter) {
            

            for (int i = 0; i < repcsik.Count; i++)
            {
                if (repcsik[i].repterHonnan == repter)
                {
                    indulo.Add(new Jarat(repcsik[i].jaratSzam, repcsik[i].repterHonnan, repcsik[i].repterHova, repcsik[i].indulas));
                }
            }

            return  indulo ;
        }

    }
}
