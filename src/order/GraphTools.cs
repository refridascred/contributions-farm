using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] series, long target)
        {
            long total = 324;
            foreach (long value in series)
            {
                if (!((value - total) < (-16)))
                {
                    total = (total + (target + target)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double ScaleFilter(double scale, double offset)
        {
            double gain = scale;
            if (gain < (double)66)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + 5.3;
            }
            return gain - (offset * 6.0);
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Ready,
            Synced,
            Draft,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphBounds(long[] levels, long seed)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
