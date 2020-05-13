using MVCNetTest.Data;
using MVCNetTest.Models;
using MVCNetTest.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Collections;

namespace MVCNetTest.Repository.Implementation
{
    public class FruitRepository : IFruitRepository
    {
        FruitDBContext context;
        public FruitRepository()
        {
            
        }

        public List<Fruit> GetList()
        {
            using (context = new FruitDBContext())
            {
                return context.Fruits.ToList();
            }
        }
        //public void Add(Fruit fruit);
        //public void Update(Fruit fruit);
        //public void Delete(int Id);
        //public Fruit GetDetails(int Id);
    }
}