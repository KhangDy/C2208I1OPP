using Exer1.Entity;
using Exer1.ValiDate;
using Exer1.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection.Metadata;


namespace Exercise1.Dao;
internal class ListProduct
{
    public List<Product> ListPro { get; set; } = [];

    public void AddProduct()
    {
        var n = Valid<int>.CheckCR("vui long nhap so luong san pham can them: ");

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"nhap san pham thu {i + 1}: ");
            var pro = new Product
            {
                ProId = Valid<string>.CheckCR("vui long nhap id: "),
                ProName = Valid<string>.CheckCR("vui long nhap ten: "),
                ProPrice = Valid<double>.CheckCR("vui long nhap gia tien: "),
                Quantity = Valid<int>.CheckCR("vui long nhap so luong: "),
                ProMfg = Valid<DateTime>.CheckCR("vui long nhap ngay san xuat: ")
            };
            ListPro.Add(pro);
        }

    }

    public void ShowProduct() => ListPro.ForEach(Console.WriteLine);

    public void DeleteProduct()
    {
        string id = Valid<string>.CheckCR("vui long nhap id can xoa: ");
        ListPro.RemoveAll(p => p.ProId == id.ToLower());

        ListPro.RemoveAll(p => String.Compare(p.ProId, id, true) == 0);
    }

}
