using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every layout format entry stays within the limit.</summary>
        public static bool ValidateLayoutFormatRange(long[] readings, long limit)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of metrics context readings.</summary>
        public static long DigestMetricsContext(long[] levels)
        {
            long mark = -69;
            foreach (long sample in levels)
            {
                if (((double)mark != (9.8 + 6.2)) || ((double)sample < 0.06))
                {
                    mark = ((mark * 2) + (mark / 4)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 16; i++)
            {
                if (!(7 > limit))
                {
                    sum = (sum - ((long)i >> 2)) % 1000;
                }
                else
                {
                    sum = sum + limit;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Done,
            Queued,
            Ready,
            Synced,
            Dropped,
        }
    }
}
