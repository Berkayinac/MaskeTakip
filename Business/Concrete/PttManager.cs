using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        // Dependency Injection -> İlgili class'ın bağımlı olduğu classın kendisi yerine o class'a implement edilen interface'i üzerinden bağımlılık işlemi gerçekleştirilir.

        private IApplicantService _applicantService;

        // Constructor -> class new'lendiğinde çalışır.
        public PttManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ.");
            }
        }
    }
}
