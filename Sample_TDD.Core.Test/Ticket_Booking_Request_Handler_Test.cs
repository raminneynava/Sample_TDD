using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Sample_TDD.Core.Handlers;
using Sample_TDD.Core.Model;

using Shouldly;

namespace Sample_TDD.Core
{
    public class Ticket_Booking_Request_Handler_Test
    {
        [Fact]
        public void should_Return_Ticket_Booking_Response_With_Request_Values()
        {
            //Arrange
            var BookingRequest = new Ticket_Booking_Request
            {
                Name = "Test Name",
                Family = "family name",
                Email = "test@name.com"
            };
            var Handler = new Ticket_Booking_Request_Handler();

            //Act
            ServiceBookingResult Result = Handler.BookService(BookingRequest);

            //Assert

            Assert.NotNull(Result);
            Assert.Equal(Result.Name, BookingRequest.Name);
            Assert.Equal(Result.Family, BookingRequest.Family);
            Assert.Equal(Result.Email, BookingRequest.Email);


            //Assert by Shouldly

            //Result.ShouldNotBeNull();
            //Result.Name.ShouldBe(BookingRequest.Name);
            //Result.Email.ShouldBe(BookingRequest.Email);
            //Result.Family.ShouldBe(BookingRequest.Family);
        }
    }
}
