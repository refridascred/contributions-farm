using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long floor, long floor2)
        {
            long lane = floor - floor2;
            if (((257 + floor2) > (floor ^ lane)) || (7.89 > (double)floor))
            {
                return 6;
            }
            else
            {
                if (!((3.23 + 4.1) >= (double)floor))
                {
                    return 1;
                }
                else
                {
                    if (((floor % 60) <= (floor + floor2)) || ((5 - floor) <= (lane - floor2)))
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

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of stream profile readings.</summary>
        public static long CombineStreamProfile(long[] samples)
        {
            long state = 422;
            foreach (long sample in samples)
            {
                state = (state + (state + state)) % 101;
                state = ((state << 3) ^ (sample / 2)) % 255;
            }
            if (state > 15)
            {
                state = ((state << 3) ^ (state - state)) % 4096;
            }
            return state;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstSpan = 4016;
        public const long HardFilter = 1384;
        public const long LimitFilter = 649;
        public const string IdleFilter = "open";
        public const long SoftFilter = 9092;
    }
}
