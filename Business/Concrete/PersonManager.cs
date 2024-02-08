using System;
using Entities.Concrete;
using System.Collections.Generic;
using Business.Abstract;
using MernisServiceReference;

namespace Business.Concrete
{
	public class PersonManager : IApplicantService
	{

		public void ApplyForMask(Person person)
		{

		}
		public List<Person> GetList()
		{
			return null;
		}

		public bool CheckPerson(Person person)
		{

			KPSPublicSoapClient client = new(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
			return client.TCKimlikNoDogrulaAsync(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear)
				.Result.Body.TCKimlikNoDogrulaResult;
		}

	}
}

