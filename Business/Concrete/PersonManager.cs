using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete
{
    // Çıplak class kalmasın
    // Entity ve Dto'lar hariç bir sınıf başka bir sınıfı kullanırken new'leyerek kullanıyorsa,
    // ileriye dönük sürdürülebilirlik zafiyeti barındırır.
    public class PersonManager : IApplicantService
    {
        // Encapsulation
        // Bir veya birden fazla parametreyi tek bir class çatısı altında gruplandırma işlemidir.
        // Bu sayede metoda yeni bir property eklendiğinde veya var olan bir property kaldırıldığında
        // Sistem içerisinde herhangi bir sürdürülebilirlik hatası meydana gelmeyecektir.
        public void ApplyForMask(Person person)
        {
             
        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName, person.LastName, person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
// if suistimali, en çok kodu kirli koda dönüştüren yapıdır.
// if tek bir iş yapmalıdır.
// if ard arda kullanılmamalıdır.
// *** birden fazla alternatif durum için if kullanılamaz. ***