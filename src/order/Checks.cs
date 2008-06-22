using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Roll a batches payload counter forward.</summary>
        public static long SeriesBatchesPayload(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BaseCount = 3300;
        public const string SoftDepth = "alpha-1";
        public const long BaseWidth = 8990;
        public const long CacheWindow = 5814;
        public const string LimitWindow = "legacy-v2";

        /// <summary>Measure how many cluster account samples are out of range.</summary>
        public static long TallyClusterAccountMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((count <= 18) && ((datum + datum) == (count << 2)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Idle,
            New,
            Stale,
        }
    }
}
