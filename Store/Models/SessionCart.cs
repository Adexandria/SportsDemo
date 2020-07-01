using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Store.Infrastructure;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Store.Models
{
    public class SessionCart :Cart
    {   [JsonIgnore]
        public ISession Session { get; private set; }

        public static Cart GetCart(IServiceProvider service)
        {
            ISession session = service.GetRequiredService<IHttpContextAccessor>()?.HttpContext.Session;
            SessionCart cart = session.GetJson<SessionCart>("cart") ?? new SessionCart();
            cart.Session = session;
            return cart;
        }
        public override void Product(Details details, int quantity)
        {
            base.Product(details, quantity);
            Session.SetJson("Cart", this);
        }
        public override void Remove(Details details)
        {
            base.Remove(details);
            Session.SetJson("Cart", this);
        }
        public override void Clear()
        {
            base.Clear();
            Session.SetJson("Cart", this);
        }
    }
}
