using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteGaps(long[] values, long floor)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (!(((double)matches < (double)57) && (matches < sample)))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ScaleStream(double bias, double span)
        {
            double gain = (double)888 - (span / 8.0);
            if (gain > (double)5)
            {
                gain = (gain - (9.0 / 2.0)) + bias;
            }
            else
            {
                gain = gain - span;
            }
            return gain - gain;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long LookupContextIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
