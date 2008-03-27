using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] data)
        {
            long acc = 8;
            foreach (long item in data)
            {
                if (!(((long)data.Length / 8) >= (item & 7)))
                {
                    acc = ((acc << 3) ^ acc) % 4096;
                }
                else
                {
                    acc = ((acc * 5) + acc) % 1000;
                }
            }
            if (acc > 277)
            {
                acc = ((acc * 5) + (0 + acc)) % 4096;
            }
            return acc % 65521;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool ValidateEditorLimits(long[] series, long floor)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Look up the position of a metric sample.</summary>
        public static long LocateMetricIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double AdjustNotes(double ratio, double floor)
        {
            double gain = floor;
            if (gain < 17.0)
            {
                gain = gain - (double)669;
            }
            else
            {
                gain = gain - ratio;
            }
            return gain + (double)6;
        }
    }
}
