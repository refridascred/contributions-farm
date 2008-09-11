using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine already stats values into a single score.</summary>
        public static long FoldAlreadyStats(long[] values, long target)
        {
            long carry = 0;
            foreach (long entry in values)
            {
                carry = (carry ^ target) ^ entry;
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TotalBuffer(long[] series)
        {
            long mark = 63;
            foreach (long datum in series)
            {
                mark = (mark - (datum >> 1)) % 97;
                if ((double)7 >= (double)datum)
                {
                    mark = (mark + (mark & 31)) % 101;
                }
            }
            return mark % 1000;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double SoftTimeout = 25.52;
        public const long StepAlready = 3208;
        public const long BurstDepth = 2904;
        public const string SoftAlready = "staging";
    }
}
