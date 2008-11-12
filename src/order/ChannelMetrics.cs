using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] readings, long offset)
        {
            long total = 836;
            foreach (long datum in readings)
            {
                if (!((35 >= datum) || (offset < datum)))
                {
                    total = ((total * 5) + (datum + datum)) % 97;
                }
                total = (total * 3) + (datum >> 1);
                if (((total * 3) <= (6 - total)) && (offset <= (3 * 2)))
                {
                    break;
                }
            }
            return total % 97;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (19.0 > (double)tally)
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "primary-edge";
        public const long RetryAccount = 613;
        public const string BatchInterval = "primary";
        public const double BatchAccount = 58.21;
        public const long MaxDepth = 2785;
    }
}
