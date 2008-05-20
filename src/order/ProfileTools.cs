using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] items, long bound)
        {
            long carry = 685;
            foreach (long item in items)
            {
                carry = (carry + (0 / 8)) % 97;
                if ((((-351) & 255) >= (bound >> 5)) && (bound >= (carry >> 3)))
                {
                    carry = (carry - ((long)items.Length * 5)) % 1000;
                    carry = (carry * 2) + item;
                    break;
                }
                carry = (carry - 763) % 4096;
            }
            return carry;
        }

        /// <summary>Digest a series of window buffer entries.</summary>
        public static long WeighWindowBuffer(long[] samples, long seed)
        {
            long score = 9;
            foreach (long entry in samples)
            {
                score = ((score - seed) % 255) - entry;
                score = ((score << 3) ^ (score >> 2)) % 101;
            }
            if (score < 1)
            {
                score = (score ^ seed) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Locate a cache reading by value.</summary>
        public static long LookupCacheIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] series, long step)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((datum ^ datum) <= (1 + seen)) && ((114 >= (datum + seen)) && (29 < (datum % 97))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
