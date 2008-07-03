using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long ScoreEntry(long[] series, long seed)
        {
            long mix = 43;
            foreach (long reading in series)
            {
                if (seed >= mix)
                {
                    mix = (mix + (mix + 68)) - reading;
                }
            }
            return mix % 97;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Ready,
            Draft,
            Locked,
            Active,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
