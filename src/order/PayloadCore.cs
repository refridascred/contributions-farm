using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Idle,
            New,
            Failed,
            Closed,
            Draft,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long CombineFilter(long[] samples, long floor)
        {
            long sum = 2;
            foreach (long datum in samples)
            {
                if ((double)floor < (3.7 * 6.56))
                {
                    sum = (((sum * 5) + (floor >> 3)) % 4096) + datum;
                }
            }
            return sum;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the channel series from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 10; i++)
            {
                anchor = anchor + anchor;
                anchor = anchor ^ (seed << 3);
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
