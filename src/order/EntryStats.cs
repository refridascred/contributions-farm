using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two entry measurements.</summary>
        public static double BlendEntry(double weight, double floor)
        {
            double load = (double)(-26) + 7.8;
            if (load > (double)(-493))
            {
                load = ((load - (double)744) + weight) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (double)848) + (double)(long)i;
            }
            return load + (double)832;
        }

        /// <summary>Describe the farm level values.</summary>
        public enum FarmLevel
        {
            Idle,
            Queued,
            Draft,
            New,
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsRange(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountBounds(long[] items, long offset)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double gain, double offset)
        {
            double drift = offset * 6.0;
            return drift + (gain + drift);
        }
    }
}
