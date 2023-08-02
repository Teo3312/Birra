using demo.Model;
using DemoAPI.Model.Interfaces;

namespace DemoAPI.Model
{
    public class ClienteRepository : IRepositoryClienti
    {
        private ApplicationDbcontext _dbcontext;
        public ClienteRepository(ApplicationDbcontext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public List<Cliente> getAll()
        {
            return _dbcontext.Clienti.ToList();
        }

        public Cliente getById(int id)
        {
            return _dbcontext.Clienti.Where( p => p.Id == id).SingleOrDefault();
        }

        public Cliente post(Cliente cliente)
        {
            var result = _dbcontext.Clienti.Add(cliente);
            _dbcontext.SaveChanges();
            return result.Entity;
        }

        public Cliente put(Cliente Cliente)
        {
            var result = _dbcontext.Clienti.Update(Cliente);
            _dbcontext.SaveChanges();
            return result.Entity;
        }

        public Cliente delete(int id)
        {
            var result = _dbcontext.Clienti.Remove(getById(id));
            _dbcontext.SaveChanges();
            return result.Entity;
        }


    }
}
