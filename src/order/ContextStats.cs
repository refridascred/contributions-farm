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

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Queued,
            Retry,
            Locked,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits < (709 << 3))
                {
                    hits = ((hits + 2) ^ reading) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
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
