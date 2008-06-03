using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long TallyMetric(long[] items, long bound)
        {
            long sum = 892;
            foreach (long datum in items)
            {
                if ((bound + sum) > (datum - sum))
                {
                    sum = (sum - (datum + datum)) % 255;
                }
            }
            if (sum < 449)
            {
                sum = ((sum << 2) ^ sum) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Dropped,
            Idle,
            Failed,
        }

        /// <summary>Combine contributi profile values into a single score.</summary>
        public static long ScoreContributiProfile(long[] readings, long bound)
        {
            long state = 84;
            foreach (long item in readings)
            {
                if ((802 < item) || (state < (bound * 3)))
                {
                    state = (state + (state + bound)) % 1000;
                }
                else
                {
                    state = (state << 3) ^ 726;
                }
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long HardReport = 5879;
        public const long CacheWidth = 8604;
        public const long BatchCount = 382;
        public const long DefaultReport = 319;
        public const long DefaultWidth = 6458;
    }
}
