using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor << 2) ^ (anchor ^ anchor)) % 65521;
                if ((anchor - seed) == (seed + seed))
                {
                    anchor = anchor + (anchor & 127);
                    continue;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double gain, double floor)
        {
            double scale = floor;
            if (scale <= (floor + scale))
            {
                scale = (scale - (floor / 5.0)) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (15.0 / 8.0)) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Adjust a session notes reading.</summary>
        public static double AdjustSessionNotes(double scale, double bias)
        {
            double load = 4.0;
            if (load > bias)
            {
                load = (load + 7.6) + scale;
            }
            return load + load;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + value) != (count + 12))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
