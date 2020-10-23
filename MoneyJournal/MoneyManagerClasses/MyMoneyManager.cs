
using MoneyManager;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MoneyManagerClasses
{
    public class MyMoneyManager
    {
        public List<MoneyTransaction> ListTransactions { get; set; }
        public DateTime PickedDate { get; set; } = DateTime.Now.Date;
        public decimal MoneyLeft { get; set; }
        public MyMoneyManager()
        {
        }


        public decimal GetTodayMoney()
        {
            decimal res = 0;
            List<MoneyTransaction> list = ListTransactions.Where(t => t.Day.Date == PickedDate.Date).ToList();
            foreach(var el in list)
            {
                if (el.IsCosts)
                {
                    res -= el.Price;
                }
                else
                {
                    res += el.Price;
                }
            }
            return res;

        }
        public void AddMoney(Income income)
        {
            ListTransactions.Add(income);
            MoneyLeft += income.Price;
        }

        public void SubMoney(Costs costs)
        {
            ListTransactions.Add(costs);
            MoneyLeft -= costs.Price;
        }

        public MyMoneyManager(List<MoneyTransaction> lists)
        {
            this.ListTransactions = lists;
        }

        public static MyMoneyManager FromFile()
        {
            if (!File.Exists("stat.json")) {
                var mmm = new MyMoneyManager(new List<MoneyTransaction>());
                return mmm;
            }
            var fromFile = File.ReadAllText("stat.json");
            return JsonConvert.DeserializeObject<MyMoneyManager>(fromFile);
        }
        public string Serialize()
        {
            return JsonConvert.SerializeObject(this);
        }
        public void SaveInFile(string json)
        {
            File.WriteAllText("stat.json", json);
        }
        public void SaveInFile()
        {
            SaveInFile(Serialize());
        }
    }
}
