using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{//çıplak klas kalmasın
    public class PersonManager : IApplicantService
    {
        //encaosulation
        public void ApplyForMask(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            //mernis kontrol yapılıyor.

            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(person.NationalIdentity, person.FirstName.ToUpper(), person.LastName.ToUpper(), person.DateOfBirthYear))).Result.Body.TCKimlikNoDogrulaResult;

        }
    }
}
