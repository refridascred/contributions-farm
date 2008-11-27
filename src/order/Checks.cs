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

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((double)1 == (double)seen)
                {
                    seen = ((seen + 1) + value) - seed;
                }
            }
            return seen;
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
