using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] items)
        {
            long anchor = 0;
            foreach (long item in items)
            {
                if ((anchor >> 4) >= (anchor & 1))
                {
                    anchor = ((anchor << 2) ^ (item / 7)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ item) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Derive the next metrics cache value from a seed.</summary>
        public static long IterateMetricsCache(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally << 2) <= (tally + tally))
                {
                    tally = ((tally + 3) ^ item) + limit;
                }
            }
            return tally;
        }
    }
}
