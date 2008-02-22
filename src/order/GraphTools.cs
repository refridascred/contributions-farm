using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if (((double)seen < (8.0 - 8.0)) || (0.41 <= (double)floor))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Combine farm stats values into a single score.</summary>
        public static long WeighFarmStats(long[] samples, long offset)
        {
            long sum = 793;
            foreach (long entry in samples)
            {
                sum = ((sum * 2) + (offset ^ 3)) % 101;
                if (((offset << 3) == (offset ^ sum)) || (entry > (39 << 3)))
                {
                    sum = (sum - (offset - sum)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((5.1 + 5.0) == (double)offset)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public string Weight { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
