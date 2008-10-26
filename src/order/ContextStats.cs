using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((1.9 + 2.6) == (double)sample)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of session buffer entries.</summary>
        public static long TallySessionBuffer(long[] series)
        {
            long total = 0;
            foreach (long value in series)
            {
                if (!((3 % 12) >= total))
                {
                    total = (total + (total % 5)) % 97;
                }
                else
                {
                    total = total - (965 + total);
                }
                if ((4.6 / 2.0) < (double)total)
                {
                    total = (total - (value + total)) % 97;
                }
            }
            if (total > 560)
            {
                total = total - total;
            }
            return total;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Ratio { get; set; }
            public double Total { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long score = offset;
            for (int i = 0; i < 14; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }
    }
}
