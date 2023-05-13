using DataLayer.Interface;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repo
{
    internal class TransactionRepo : dBinstance, iRepo<Transaction, int, bool>
    {
        public List<Transaction> Get()
        {
            return db.Transactions.ToList();
        }

        public Transaction Get(int id)
        {
            return db.Transactions.Find(id);
        }

        public bool Insert(Transaction transaction)
        {
            db.Transactions.Add(transaction);
            return db.SaveChanges() > 0;
        }

        public bool Update(Transaction transaction)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            var newTransaction = db.Transactions.Find(id);
            if (newTransaction != null)
            {
                db.Transactions.Remove(newTransaction);
                return db.SaveChanges() > 0;
            }

            else return false;
        }
    }
}
