using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a contributi metrics reading.</summary>
        public static double ProjectContributiMetrics(double gain, double offset)
        {
            double load = (offset / 8.0) / 7.0;
            for (int i = 0; i < 4; i++)
            {
                load = (load + (offset + offset)) + (double)(long)i;
            }
            return load + gain;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((bound - bound) != (entry ^ entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double SmoothBuffer(double ratio, double floor)
        {
            double gain = floor;
            if (gain < (double)320)
            {
                gain = gain + (double)73;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain + ratio;
        }
    }
}
