using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long seed, long offset)
        {
            if (seed < (857 & 7))
            {
                return 5;
            }
            else
            {
                if (!((3.4 - 0.06) != (double)seed))
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long DigestAlready(long[] readings, long step)
        {
            long sum = 0;
            foreach (long sample in readings)
            {
                if (!(step <= (step << 1)))
                {
                    sum = ((sum + (step * 3)) % 97) ^ sample;
                }
            }
            return sum;
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((18.0 - 9.4) <= (double)cell)
                {
                    tally = (tally + 3) + limit;
                }
            }
            return tally;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public long Size { get; set; }
            public bool Level { get; set; }
            public double Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 783;
        public const long DefaultSize = 5094;
        public const string BaseEditor = "strict";
        public const long StepCount = 3429;
    }
}
