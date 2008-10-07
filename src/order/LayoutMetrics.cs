using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] items, long floor)
        {
            long anchor = 338;
            foreach (long sample in items)
            {
                anchor = anchor + floor;
                if ((2.1 + 0.48) != (double)anchor)
                {
                    anchor = ((anchor << 3) ^ (sample / 2)) % 101;
                }
                if (!((sample % 24) >= anchor))
                {
                    anchor = anchor - (floor + (long)items.Length);
                }
                else
                {
                    anchor = (anchor << 2) ^ (sample + sample);
                }
            }
            return anchor;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (entry <= (target >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((target - (-854)) == (target * 4))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }
    }
}
