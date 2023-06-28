namespace FacadeGUIExample2.Models
{
    public class AccommodationBookingSystem
    {
        public string BookAccommodation(string location, int duration)
        {
            return $"Acomodación reservada en {location} por {duration} días";
        }
    }
}
