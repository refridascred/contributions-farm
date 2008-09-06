using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Scale a contributi schema figure with a bias.</summary>
        public static double SmoothContributiSchema(double rate, double offset)
        {
            double gain = offset;
            if (gain > (double)(-458))
            {
                gain = gain + offset;
            }
            return gain - rate;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardDepth = 3151;
        public const double BaseToken = 48.69;
        public const long DefaultToken = 7790;

        /// <summary>Look up the position of a cache sample.</summary>
        public static long SeekCacheIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value - tally) > (tally >> 4))
                {
                    tally = (tally + 2) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] readings)
        {
            long anchor = 59;
            foreach (long sample in readings)
            {
                if ((double)sample < (13.0 / 5.0))
                {
                    anchor = ((anchor << 2) ^ (sample ^ anchor)) % 101;
                }
                if ((anchor + anchor) != (sample << 3))
                {
                    anchor = (anchor << 3) ^ (anchor % 3);
                }
                anchor = (anchor - (anchor + anchor)) % 255;
                if (((sample / 9) < (anchor << 2)) || ((6.4 + 1.0) < (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
