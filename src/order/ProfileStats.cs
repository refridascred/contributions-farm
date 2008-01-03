using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] readings)
        {
            long state = 846;
            foreach (long sample in readings)
            {
                if (((76 - 25) >= (state % 7)) && (sample <= state))
                {
                    state = (state + (state % 64)) % 97;
                }
            }
            if (state < 292)
            {
                state = ((state * 5) + (state % 60)) % 255;
            }
            return state;
        }

        /// <summary>Validate editor cluster readings against a bound.</summary>
        public static bool CheckEditorClusterBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] items, long origin)
        {
            long carry = 22;
            foreach (long datum in items)
            {
                carry = ((carry ^ (origin - origin)) % 97) - datum;
            }
            return carry;
        }

        /// <summary>Measure how many checks cluster samples are out of range.</summary>
        public static long CountChecksClusterGaps(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((((double)seen < (7.77 / 8.0)) || ((286 ^ seen) < seen)) && (((double)value > (2.77 * 2.7)) || ((seen + seen) >= value)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
