using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)seen > (5.04 / 7.0))
                {
                    seen = (seen + 1) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Project the next commits contributi value.</summary>
        public static double ProjectCommitsContributi(double gain, double floor)
        {
            double rate = floor;
            if (rate < (double)5)
            {
                rate = rate + (rate - rate);
            }
            return rate - (floor + gain);
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((((-790) >> 2) > (18 ^ cell)) || (hits < (hits ^ cell))) || ((double)seed >= (3.37 / 4.0)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
