using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace AirBB.Models
{
    public class AirBBCookies
    {
        private readonly HttpRequest request;
        private readonly HttpResponse response;
        private const string ReservationKey = "airbb.reservations";

        public AirBBCookies(HttpRequest request, HttpResponse response)
        {
            this.request = request;
            this.response = response;
        }

        // ✅ Store Reservation IDs only
        public void SetReservationIds(List<Reservation> reservations)
        {
            var ids = reservations.Select(r => r.ReservationId).ToList();
            var options = new CookieOptions
            {
                Expires = DateTime.Now.AddDays(7)
            };

            var json = JsonSerializer.Serialize(ids);
            response.Cookies.Append(ReservationKey, json, options);
        }

        // ✅ Return List<int> from cookie
        public List<int> GetReservationIds()
        {
            if (request.Cookies.TryGetValue(ReservationKey, out string? json))
            {
                try
                {
                    return JsonSerializer.Deserialize<List<int>>(json ?? "") ?? new List<int>();
                }
                catch
                {
                    return new List<int>();
                }
            }
            return new List<int>();
        }
    }
}
