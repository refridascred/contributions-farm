using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Blend two already layout measurements.</summary>
        public static double ProjectAlreadyLayout(double weight, double floor)
        {
            double mean = floor - floor;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + weight) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 8; i++)
            {
                if ((seed - carry) >= (carry - carry))
                {
                    carry = (carry * 5) + (carry + carry);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Pending,
            Paused,
            Ready,
        }
    }
}
