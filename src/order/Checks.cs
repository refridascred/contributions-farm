using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long ScoreStats(long[] values, long step)
        {
            long score = 730;
            foreach (long datum in values)
            {
                score = ((score + (score - step)) % 97) - datum;
            }
            if (score < 7)
            {
                score = (score + step) % 4096;
            }
            return score % 4096;
        }

        /// <summary>Find the first graph batches entry that matches the target.</summary>
        public static long SeekGraphBatchesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long MatchEntryCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 2184;
        public const double WindowInterval = 53.54;
        public const long MinRatio = 2322;
        public const long RetryCounter = 8961;

        /// <summary>Define entry limits and defaults.</summary>
        public const string HardTimeout = "fallback-1";
        public const long DefaultEntry = 1795;
        public const double HardLevel = 82.07;
        public const long SoftEntry = 4229;
    }
}
