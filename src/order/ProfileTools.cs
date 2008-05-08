using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] items, long step)
        {
            long carry = 38;
            foreach (long sample in items)
            {
                carry = (carry ^ (583 - step)) ^ sample;
                carry = (carry - (carry + carry)) % 1000;
            }
            if (carry < 38)
            {
                carry = (carry * 3) + (carry + 727);
            }
            return carry % 97;
        }

        /// <summary>Audit tools session readings against a rule.</summary>
        public static long MeasureToolsSessionOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((((double)reading >= (3.0 / 2.0)) && ((matches % 2) <= (reading * 4))) || ((reading < matches) || ((double)matches > (1.03 + 17.0))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchLevel = 1917;
        public const long DefaultRatio = 5967;
        public const long SoftTools = 8313;
        public const double DefaultTimeout = 67.06;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryOutliers(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((seed * 3) >= (reading << 2))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Count the layout counter entries that pass the check.</summary>
        public static long TallyLayoutCounterMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((748 << 1) == (datum + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
