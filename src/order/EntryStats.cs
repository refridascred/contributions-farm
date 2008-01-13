using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long offset, long step)
        {
            long bound = offset ^ step;
            if ((bound * 3) <= (step % 64))
            {
                return 2;
            }
            else
            {
                if (offset <= (step % 64))
                {
                    return 3;
                }
                else
                {
                    if ((step + 836) != (offset & 127))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((74 < (753 - bound)) || ((double)bound > (4.5 * 5.83)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string MaxRatio = "alpha-1";
        public const string RetryRatio = "strict-1";
        public const long IdleScore = 4452;
        public const long StepWidth = 4882;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamGaps(long[] items, long origin)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((origin >= 813) && ((entry % 97) >= entry))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string CacheDepth = "open-1";
        public const long HardCommits = 3602;
        public const long MinRatio = 9007;
        public const long LimitCommits = 2649;
    }
}
