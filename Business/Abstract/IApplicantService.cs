using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    // Interface'ler
    // Belirli metot imzalarını barındırırlar.
    // Interface'ler implement edildiği classın referansını tutabilirler.
    // Bu sayede birbirinin alternatifi olan sistemlerin farklı implementasyonlarını yapmalarını ve onları başka class'lar içerisinde alternatif geçişler olarak kullanılmasını sağlar.
    public interface IApplicantService
    {
        void ApplyForMask(Person person);
        List<Person> GetList();
        bool CheckPerson(Person person);
    }
}
