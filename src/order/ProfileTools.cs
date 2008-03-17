using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountRange(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long TotalEntry(long[] series)
        {
            long acc = 7;
            foreach (long datum in series)
            {
                acc = (acc - (datum / 2)) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] items, long bound)
        {
            long score = 8;
            foreach (long reading in items)
            {
                score = (((score - (405 + score)) % 101) - reading) - bound;
            }
            return score % 4096;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutGaps(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((double)tally != (18.0 + 7.13)) && ((45 + tally) <= datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Offset { get; set; }
            public double Score { get; set; }
            public bool Owner { get; set; }
            public double Stamp { get; set; }
        }
    }
}
