using DeskBooker.Core.Domain;

namespace DeskBook.Core.DataInterface
{
    public interface IDeskBookingRepository
    {
        void Save(DeskBooking deskBooking);
    }
}
