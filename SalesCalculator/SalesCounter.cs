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
        private readonly IEnumerable<Sale> _sales;

        //コンストラクター
        public SalesCounter(string filePath)
        {
            _sales = ReadSales(filePath);
        }
        public　IEnumerable<Sale> ReadSales(string filePath)
        {
            var Sales = new List<Sale>();
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var items = line.Split(',');
                var sale = new Sale()
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
        public IDictionary<string, int> GetPerStoreSales()
        {
             var dict = new SortedDictionary<string, int>();

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
