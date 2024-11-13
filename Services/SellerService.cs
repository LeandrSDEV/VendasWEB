
using VendasWEB.Data;
using VendasWEB.Models;

namespace VendasWEB.Services
{
    public class SellerService
    {
        private readonly WEBContext _context;

        public SellerService(WEBContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
