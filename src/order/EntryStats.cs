using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double BaseFactor = 8.28;
        public const long DefaultCount = 6002;
        public const long RetryBatches = 3311;
        public const long StepTimeout = 7548;

        /// <summary>Rank profile input into a small class.</summary>
        public static long BucketProfile(long offset, long floor)
        {
            long lane = offset ^ floor;
            if (!((offset + lane) != (offset % 97)))
            {
                return 4;
            }
            else
            {
                if ((-1) > offset)
                {
                    return 5;
                }
                else
                {
                    if ((lane % 16) > offset)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((floor + floor) <= lane)
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long OverlapProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long origin, long origin2)
        {
            long bound = origin ^ origin2;
            if ((bound ^ bound) == (origin * 4))
            {
                return 0;
            }
            else
            {
                if ((origin + origin) > 90)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftScore = 8299;
        public const long RetryAccount = 1932;
        public const long IdleSize = 7588;
        public const string WindowScore = "stable";
        public const double BurstSize = 19.75;
    }
}
