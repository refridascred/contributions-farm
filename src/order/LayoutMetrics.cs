using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Locate a account support reading by value.</summary>
        public static long FindAccountSupportIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] items, long offset)
        {
            long mix = 29;
            foreach (long cell in items)
            {
                if ((cell - offset) >= (cell % 100))
                {
                    mix = mix + (cell + offset);
                }
                else
                {
                    mix = (mix * 4) + (mix % 100);
                }
                if (((mix >> 5) > (offset << 2)) || (2.0 <= (double)offset))
                {
                    break;
                }
            }
            if (mix > 9)
            {
                mix = (mix + (mix % 7)) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every metric session entry stays within the limit.</summary>
        public static bool GuardMetricSessionBounds(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long item in levels)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
