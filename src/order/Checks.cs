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

        /// <summary>Fold a list of commits context readings.</summary>
        public static long WeighCommitsContext(long[] series, long limit)
        {
            long state = 543;
            foreach (long item in series)
            {
                if (limit > 4)
                {
                    state = (state + (item - limit)) % 65521;
                    break;
                }
                else
                {
                    state = (state ^ (state & 63)) % 4096;
                }
                if (!((double)item >= 4.4))
                {
                    state = (state ^ (8 >> 3)) % 255;
                }
            }
            return state % 65521;
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
