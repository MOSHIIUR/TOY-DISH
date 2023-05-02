using BusinessLayer.DTOs;
using DataLayer.Manager;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Services
{
    public class TransactionService
    {
        public static List<TransactionDTO> Get()
        {
            return convert(DataAccess.TransactionData().Get());
        }

        public static TransactionDTO Get(int id)
        {
            return convert(DataAccess.TransactionData().Get(id));
        }

        public static List<Transaction> Get10()
        {
            var data = (from r in DataAccess.TransactionData().Get()
                        where r.Id < 11
                        select r).ToList();
            return data;
        }

        public static bool Create(TransactionDTO Transaction)
        {
            var data = convert(Transaction); //convert DTO to Transaction

            var res = DataAccess.TransactionData().Insert(data); //pass to data layer

            //pass result to app layer
            if (res) return true;
            else return false;


        }

        public static bool Delete(int id)
        {
            return DataAccess.TransactionData().Delete(id);
        }

        //take list of Transaction return TransactionDTO
        static List<TransactionDTO> convert(List<Transaction> transactions)
        {
            var data = new List<TransactionDTO>();
            foreach (var t in transactions)
            {
                data.Add(new TransactionDTO
                {
                    Id = t.Id,
                    Price = t.Price,
                    Time= t.Time
                });
            }

            return data;
        }

        //take a Transaction and retun it's dto
        static TransactionDTO convert(Transaction transaction)
        {
            return new TransactionDTO()
            {
                Id = transaction.Id,
                Price = transaction.Price,
                Time = transaction.Time
            };
        }

        //take a TransactionDTO and retun just the Transaction
        static Transaction convert(TransactionDTO transaction)
        {
            return new Transaction()
            {
                Id = transaction.Id,
                Price = transaction.Price,
                Time = transaction.Time
            };
        }
    }
}
