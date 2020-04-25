using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class PttManager
    {
        private IApplicantService _applicantService;
        public void GiveMask(Person person)
        {

            if (personManager.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "maske verildi");
            }
        }
    }
}
