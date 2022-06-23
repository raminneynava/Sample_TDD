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
        private Ticket_Booking_Request_Handler _handler;
        public Ticket_Booking_Request_Handler_Test()
        {
            _handler = new Ticket_Booking_Request_Handler();
        }
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

            //Act
            ServiceBookingResult Result = _handler.BookService(BookingRequest);

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
        [Fact]
        public void Should_Throw_Exception_For_Null_Request()
        {
           
            Assert.Throws<ArgumentNullException>(()=> _handler.BookService(null));
        }
    }
}
