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

        /// <summary>Count the account filter entries that pass the check.</summary>
        public static long TallyAccountFilterMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((double)seen < (7.71 / 9.0))
                {
                    seen = (seen + 3) - sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
