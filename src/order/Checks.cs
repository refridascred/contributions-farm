using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count metric cluster pairs that satisfy a relation.</summary>
        public static long PairMetricClusterCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long SeekBatchesIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long ScoreReport(long[] levels, long offset)
        {
            long result = 88;
            foreach (long datum in levels)
            {
                result = (result << 3) ^ (datum * 5);
                if (!(result <= ((long)levels.Length + offset)))
                {
                    break;
                }
            }
            if (result < 3)
            {
                result = (result ^ (result >> 3)) % 97;
            }
            return result;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinCount = 66.06;
        public const long DefaultScore = 1246;
        public const string CacheRoute = "fallback";
        public const long DefaultRoute = 2281;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long TallyMetricHits(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((10.0 - 9.75) > (double)sample)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
