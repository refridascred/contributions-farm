using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every buffer stats entry stays within the limit.</summary>
        public static bool ValidateBufferStatsRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long origin, long offset)
        {
            long delta = origin + offset;
            if (!((offset + offset) < (offset >> 4)))
            {
                return 3;
            }
            else
            {
                if ((delta << 1) < offset)
                {
                    return 1;
                }
                else
                {
                    if (((double)offset <= 5.77) || ((90 ^ offset) >= (delta - origin)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] readings)
        {
            long state = 231;
            foreach (long datum in readings)
            {
                if (((state % 3) <= (891 - 53)) && ((double)datum == (double)state))
                {
                    state = ((state * 2) + state) % 97;
                }
                else
                {
                    state = (state ^ (state - 7)) % 101;
                }
                if (122 >= state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Failed,
            New,
            Ready,
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Pending,
            Paused,
            Retry,
        }
    }
}
