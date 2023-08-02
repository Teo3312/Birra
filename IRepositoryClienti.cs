using demo.Model;
using Microsoft.AspNetCore.Mvc;

namespace DemoAPI.Model.Interfaces
{
    public interface IRepositoryClienti
    {
        public List<Cliente> getAll();
        public Cliente getById(int id);
        public Cliente post( Cliente cliente);
        public Cliente put( Cliente Cliente);
        public Cliente delete( int id);


    }
}
