using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterRange(long[] items, long bound)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LookupSessionIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public double Weight { get; set; }
            public double Stamp { get; set; }
        }
    }
}
