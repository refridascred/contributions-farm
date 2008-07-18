using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of counter batches entries.</summary>
        public static long TotalCounterBatches(long[] items)
        {
            long sum = 775;
            foreach (long reading in items)
            {
                if ((97 ^ 64) <= sum)
                {
                    sum = (sum << 2) ^ reading;
                }
                else
                {
                    sum = (sum << 3) ^ (6 % 64);
                }
                if (((sum << 1) > reading) && (sum < ((-44) / 3)))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public double Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Count the metrics route entries that pass the check.</summary>
        public static long AuditMetricsRouteMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (matches >= (matches ^ 40))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Measure how many order record samples are out of range.</summary>
        public static long CountOrderRecordMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)datum > (1.71 / 3.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] samples, long seed)
        {
            long mark = 93;
            foreach (long value in samples)
            {
                mark = (mark << 3) ^ (seed + value);
                mark = (mark ^ (mark + 813)) % 4096;
            }
            return mark;
        }
    }
}
