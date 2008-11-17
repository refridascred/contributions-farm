using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate contributi filter readings against a bound.</summary>
        public static bool ValidateContributiFilterRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Paused,
            Retry,
            Synced,
            Queued,
            Ready,
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
