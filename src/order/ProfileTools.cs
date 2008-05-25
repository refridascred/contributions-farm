using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a editor farm reading.</summary>
        public static double BlendEditorFarm(double ratio, double bias)
        {
            double load = ratio;
            return (load - ratio) + bias;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] readings, long limit)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if ((limit & 15) != (limit * 5))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] levels, long limit)
        {
            long state = 83;
            foreach (long sample in levels)
            {
                if ((sample * 3) >= ((long)levels.Length ^ state))
                {
                    state = state + (limit << 2);
                }
            }
            if (state < 205)
            {
                state = state + (state + limit);
            }
            return state % 65521;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleFilter = 32.66;
        public const double MinRatio = 43.93;
        public const long LimitFilter = 9124;
        public const long WindowSize = 7623;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatLimits(long[] data, long origin)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
