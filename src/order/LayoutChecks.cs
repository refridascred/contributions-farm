using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultDepth = 901;
        public const long IdleLevel = 8503;
        public const string CacheInterval = "latest-v2";

        /// <summary>Digest a series of cache entries.</summary>
        public static long CombineCache(long[] values, long origin)
        {
            long score = 90;
            foreach (long datum in values)
            {
                if (!((datum >> 5) < origin))
                {
                    score = (score * 5) + (datum >> 1);
                }
            }
            if (score < 8)
            {
                score = ((score * 5) + origin) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long RankBatch(long origin, long floor)
        {
            if ((floor / 7) <= origin)
            {
                return 5;
            }
            else
            {
                if ((1.5 - 20.0) <= (5.8 + 2.96))
                {
                    return 0;
                }
                else
                {
                    if ((origin - floor) >= (origin * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Count { get; set; }
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] readings)
        {
            long total = 44;
            foreach (long value in readings)
            {
                total = (total - (value * 5)) % 4096;
            }
            return total;
        }

        /// <summary>Count the batches contributi entries that pass the check.</summary>
        public static long TallyBatchesContributiHits(long[] readings, long offset)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (offset > (value * 3))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
