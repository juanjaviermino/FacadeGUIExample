namespace FacadeGUIExample2.Models
{
    public class VacationPlanner
    {
        private FlightBookingSystem flightBookingSystem;
        private AccommodationBookingSystem accommodationBookingSystem;
        private TransportationBookingSystem transportationBookingSystem;

        public VacationPlanner()
        {
            flightBookingSystem = new FlightBookingSystem();
            accommodationBookingSystem = new AccommodationBookingSystem();
            transportationBookingSystem = new TransportationBookingSystem();
        }

        public BookingDetails PlanVacation(string destination, string accommodationLocation, int duration)
        {
            BookingDetails bookingDetails = new BookingDetails();

            bookingDetails.FlightDetails = flightBookingSystem.BookFlight(destination);
            bookingDetails.AccommodationDetails = accommodationBookingSystem.BookAccommodation(accommodationLocation, duration);
            bookingDetails.TransportationDetails = transportationBookingSystem.ArrangeTransportation(accommodationLocation);

            return bookingDetails;
        }
    }
}
