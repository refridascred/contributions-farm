using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long BucketCommits(long step, long offset)
        {
            long step2 = step + offset;
            if ((double)step2 <= (7.02 * 7.91))
            {
                return 1;
            }
            else
            {
                if ((step * 5) <= (32 ^ 16))
                {
                    return 7;
                }
                else
                {
                    if ((double)2 < (double)offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftGraph = 2615;
        public const long BaseInterval = 8911;
        public const long MinRatio = 3529;

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
