using Microsoft.AspNetCore.Mvc;         // MVCの機能を使用 
using Microsoft.EntityFrameworkCore;    // ToListAsyncを使用 
using MvcBasicSample.Data;              // AppDbContextを使用 

using MvcBasicSample.Controllers;

namespace MvcBasicSample.Controllers;

public class ProductsController : Controller
{
    private readonly AppDbContext _db;  // DBへ問い合わせるためのフィールド 

    // ASP.NET Coreから必要なAppDbContextを受け取る 
    public ProductsController(AppDbContext db)
    {
        _db = db;                       // 受け取ったAppDbContextをフィールドに保存 
    }

    // /Products/Indexで商品一覧を取得する
}