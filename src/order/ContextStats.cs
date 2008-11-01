using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of cache editor readings.</summary>
        public static long CompareCacheEditorCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of filter already entries.</summary>
        public static long DigestFilterAlready(long[] readings)
        {
            long state = -69;
            foreach (long item in readings)
            {
                if (610 > (0 + state))
                {
                    state = ((state << 3) ^ item) % 255;
                }
                if ((item + state) < (state * 4))
                {
                    break;
                }
            }
            if (state < 41)
            {
                state = (state * 4) + ((long)readings.Length / 9);
            }
            return state;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
