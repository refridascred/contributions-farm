using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Token { get; set; }
            public bool Offset { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of command channel entries.</summary>
        public static long TotalCommandChannel(long[] samples, long floor)
        {
            long total = 6;
            foreach (long datum in samples)
            {
                total = (total ^ (42 ^ 343)) % 1000;
                if ((floor / 8) == (datum * 2))
                {
                    total = (total << 2) ^ (datum ^ total);
                }
                else
                {
                    total = (total * 2) + datum;
                }
                if ((datum / 7) != (floor + datum))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count stats profile pairs that satisfy a relation.</summary>
        public static long CompareStatsProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }
    }
}
