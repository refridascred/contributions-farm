using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long StepBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                if ((double)sum > (20.0 + 5.0))
                {
                    sum = sum + (sum & 7);
                }
                sum = ((sum << 3) ^ (sum + (long)i)) % 255;
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Draft,
            Stale,
            Queued,
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long StepAlready(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (anchor ^ ((long)i2 * 2)) % 97;
                }
                anchor = (anchor << 3) ^ 28;
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
