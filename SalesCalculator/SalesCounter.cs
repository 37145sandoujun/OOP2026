using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace SalesCalculator
{//売上集計プログラムクラス
    public class SalesCounter
    {
        private readonly List<Sale> _sales;

        //コンストラクター
        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);
        }
        public　 List<Sale> ReadSales(string filePath)
        {
            List<Sale> Sales = new List<Sale>();
            String[] lines = File.ReadAllLines(filePath);


            foreach (string line in lines)
            {
                string[] items = line.Split(',');
                Sale sale = new Sale()
                {
                    ShopName = items[0],
                    ProductCategory = items[1],
                    Amount = int.Parse(items[2]),
                };

                Sales.Add(sale);
            }
            return Sales;
        }
        //店舗別売り上げを求める
        public Dictionary<string, int> GetPerStoreSales()
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach(var sale in _sales){
                //すでに名前が辞書のキーに登録されているか？
                if (dict.ContainsKey(sale.ShopName))
                    //登録されている場合
                    dict[sale.ShopName] += sale.Amount;//売上の足しこみ
                else
                    //未登録の場合
                    dict[sale.ShopName]=sale.Amount;//新規に売り上げを登録
            }
            return dict;
        }
    }
}
