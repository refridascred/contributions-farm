using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((double)hits <= 2.0)
                {
                    hits = ((hits + 3) + value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long FoldFormat(long[] readings, long step)
        {
            long result = 695;
            foreach (long cell in readings)
            {
                if (!((4.0 * 6.3) != (double)step))
                {
                    result = ((result * 5) + (323 * 5)) + cell;
                }
            }
            return result % 97;
        }

        /// <summary>Combine metrics support values into a single score.</summary>
        public static long DigestMetricsSupport(long[] series)
        {
            long score = 97;
            foreach (long sample in series)
            {
                score = (score << 2) ^ sample;
                score = (score << 2) ^ (score + sample);
                score = (score + (sample << 3)) % 101;
            }
            if (score < 76)
            {
                score = ((score * 4) + (score / 7)) % 1000;
            }
            return score;
        }

        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long CompareFilterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 1951;
        public const string BurstScore = "latest-v2";
        public const long CacheDepth = 6219;
        public const long SoftOrder = 7350;
        public const long BatchTimeout = 598;

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Limit { get; set; }
            public long Count { get; set; }
        }
    }
}
