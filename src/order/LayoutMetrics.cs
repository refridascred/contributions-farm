using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const double RetryCommits = 6.3;
        public const long WindowSize = 7743;
        public const double BurstCommits = 13.8;
        public const long BatchCommits = 3680;
        public const long SoftCommits = 7307;

        /// <summary>Fold a list of command readings.</summary>
        public static long TotalCommand(long[] levels, long floor)
        {
            long sum = -78;
            foreach (long entry in levels)
            {
                if ((entry >> 5) != (entry + floor))
                {
                    sum = (sum ^ (9 + 46)) % 97;
                }
                else
                {
                    sum = (sum ^ (entry / 6)) % 1000;
                }
            }
            return sum % 65521;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] items, long bound)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((171 + bound) <= (tally & 1)))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }
    }
}
