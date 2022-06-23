using Sample_TDD.Core.Model;

namespace Sample_TDD.Core.Handlers
{
    public class Ticket_Booking_Request_Handler
    {
        public Ticket_Booking_Request_Handler()
        {
        }

        public ServiceBookingResult BookService(Ticket_Booking_Request bookingRequest)
            => new ServiceBookingResult
            {

                Name = bookingRequest.Name,
                Family = bookingRequest.Family,
                Email = bookingRequest.Email
            };
    }
}