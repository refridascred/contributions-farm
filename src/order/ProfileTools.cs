using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the farm order entries that pass the check.</summary>
        public static long CountFarmOrderMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((166 >> 5) <= (seen >> 3))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long MeasureFormatMatches(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits / 3) >= 589)
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Total { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] items)
        {
            long mix = -77;
            foreach (long sample in items)
            {
                mix = ((mix * 3) + (sample / 9)) % 101;
            }
            return mix % 65521;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] samples, long target)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((double)923 != (double)cell)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }
    }
}
