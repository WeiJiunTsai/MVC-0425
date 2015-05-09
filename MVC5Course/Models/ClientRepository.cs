using System;
using System.Linq;
using System.Collections.Generic;
	
namespace MVC5Course.Models
{   
	public  class ClientRepository : EFRepository<Client>, IClientRepository
	{
        public override IQueryable<Client> All()
        {
            return base.All().Where(p=>p.isDelete == false);
        }
        public IQueryable<Client> SearchByGender(string gender)
        {
            return base.All().Where(p => p.Gender == gender).Take(10);
        }
        public Client Find(int? id)
        {
            return this.All().FirstOrDefault(p => p.ClientId == id);
        }

        internal IQueryable<Client> SearchByCity(string city)
        {
            if (String.IsNullOrEmpty(city))
            {
                return this.All();
            }
            else
            {
                return this.All().Where(p => p.City == city).Take(10);
            }
        }
    }

	public  interface IClientRepository : IRepository<Client>
	{

	}
}