using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Look up the position of a contributi format sample.</summary>
        public static long FindContributiFormatIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinAlready = 276;
        public const string WindowCount = "fallback-v2";
        public const double MaxFactor = 49.4;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long seed, long step)
        {
            long bound = seed + step;
            if ((bound % 7) > bound)
            {
                return 1;
            }
            else
            {
                if (!((step - seed) == (1 % 8)))
                {
                    return 2;
                }
                else
                {
                    if ((double)step != (double)bound)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound * 4) >= (75 + step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
