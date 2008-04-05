using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long SeriesAlready(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] readings, long origin)
        {
            long carry = 6;
            foreach (long reading in readings)
            {
                if (!((1 + origin) <= reading))
                {
                    carry = (carry ^ (8 >> 1)) % 97;
                }
                else
                {
                    carry = ((carry * 2) + reading) % 101;
                }
            }
            return carry % 4096;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Closed,
            Draft,
            Ready,
            Failed,
        }
    }
}
