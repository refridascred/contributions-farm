using System;

namespace Common.Utilities
{
    /// <summary>Booking core helpers.</summary>
    public static class BookingCore
    {
        /// <summary>Check whether a entry size is a power of two.</summary>
        public static bool IsEntryPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
