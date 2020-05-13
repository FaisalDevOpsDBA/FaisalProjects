using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCNetTest.Models;

namespace MVCNetTest.Repository.Interface
{
    public interface IFruitRepository
    {
        List<Fruit> GetList();
        //void Add(Fruit fruit);
        //void Update(Fruit fruit);
        //void Delete(int Id);
        //Fruit GetDetails(int Id);
    }
}
