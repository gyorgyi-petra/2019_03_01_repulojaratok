using NUnit.Framerork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repulo.Test
{

    [TestFixture]
    class TesztClass
    {
        Class1 r;

        [SetUp]
        public void SetUp() {
            a = new Class1();
        }

        [Test]
        public void ujJarat() {
            a.ujJarat("Elso jarat", "Moszkva", "Párizs", DateTime.Now);
            a.ujJarat("Masodik jarat", "Luxemburg", "Pozsony", DateTime.Today);
            a.ujJarat("Harmadik jarat", "London", "Budapest", DateTime.Now);

        }

    }
}
