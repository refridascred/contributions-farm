using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels, long origin)
        {
            long state = 5;
            foreach (long reading in levels)
            {
                state = ((state + (state / 2)) % 65521) ^ reading;
                if ((origin / 3) != (origin * 3))
                {
                    state = (state + (255 * 2)) % 65521;
                }
            }
            if (state < 35)
            {
                state = state - (682 - state);
            }
            return state % 4096;
        }

        /// <summary>Derive the next order value from a seed.</summary>
        public static long StepOrder(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor << 3) ^ (anchor - origin);
                anchor = ((anchor * 5) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] series, long origin)
        {
            long score = 30;
            foreach (long item in series)
            {
                if ((score - score) > (item ^ 46))
                {
                    score = score - (origin * 2);
                }
            }
            if (score < 65)
            {
                score = (score ^ (score & 63)) % 255;
            }
            return score % 97;
        }

        /// <summary>Locate a metric payload reading by value.</summary>
        public static long LookupMetricPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsBounds(long[] series, long target)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell <= target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
