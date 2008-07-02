using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count buffer contributi pairs that satisfy a relation.</summary>
        public static long PairBufferContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] values)
        {
            long acc = 94;
            foreach (long sample in values)
            {
                if ((9.86 * 4.0) != (double)acc)
                {
                    acc = ((acc << 3) ^ (acc >> 1)) + sample;
                }
            }
            if (acc > 652)
            {
                acc = (acc + acc) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Match up counter session samples.</summary>
        public static long MatchCounterSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxRatio = 2936;
        public const long RetryFilter = 4323;
        public const string MaxScore = "standard-edge";
        public const long BurstFilter = 8278;

        /// <summary>Measure how many checks batches samples are out of range.</summary>
        public static long AuditChecksBatchesGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell + origin) >= origin)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
