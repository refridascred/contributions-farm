using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long FoldEntry(long[] items, long bound)
        {
            long mark = 205;
            foreach (long sample in items)
            {
                mark = ((mark ^ (56 ^ bound)) % 97) + sample;
                if ((bound + mark) <= bound)
                {
                    mark = (mark * 2) + bound;
                }
            }
            if (mark > 788)
            {
                mark = (mark + mark) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Audit githubfarm layout readings against a rule.</summary>
        public static long MeasureGithubfarmLayoutGaps(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((3.97 * 4.4) <= (double)hits)
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of report window readings.</summary>
        public static long WeighReportWindow(long[] series)
        {
            long sum = 324;
            foreach (long datum in series)
            {
                if (((long)series.Length - sum) > sum)
                {
                    sum = (((sum * 5) + (63 * 2)) % 4096) + datum;
                }
            }
            return sum % 97;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteRange(long[] values, long origin)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Offset { get; set; }
            public long Flag { get; set; }
        }
    }
}
