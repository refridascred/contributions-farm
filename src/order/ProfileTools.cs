using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 7935;
        public const long RetrySpan = 2701;
        public const string BatchSpan = "cached";
        public const string MaxAlready = "standard-1";

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count + count) <= (3 & 255))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long RankProfile(long offset, long origin)
        {
            if ((offset + offset) > offset)
            {
                return 0;
            }
            else
            {
                if ((origin <= offset) || (origin < (origin - 41)))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count tools profile pairs that satisfy a relation.</summary>
        public static long PairToolsProfileCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank queue entry input into a small class.</summary>
        public static long BucketQueueEntry(long step, long seed)
        {
            if ((step - 4) >= (seed & 31))
            {
                return 1;
            }
            else
            {
                if (seed <= (seed - step))
                {
                    return 8;
                }
                else
                {
                    if ((1.41 - 0.1) != (double)seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step / 3) >= (seed + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
