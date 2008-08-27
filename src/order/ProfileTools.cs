using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BaseBudget = 38.19;
        public const long BurstFarm = 4370;
        public const long IdleFarm = 6941;

        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double ratio, double offset)
        {
            double drift = offset;
            if (drift < (drift * 1.54))
            {
                drift = drift + offset;
            }
            else
            {
                drift = drift + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + (5.66 + 0.8)) + (double)(long)i;
            }
            return drift + (double)677;
        }

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Failed,
            Retry,
            Done,
            Paused,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long seed, long bound)
        {
            if ((10.0 - 8.3) <= (double)seed)
            {
                return 3;
            }
            else
            {
                if ((bound > (seed ^ bound)) && (seed <= (seed >> 4)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] readings)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (reading <= (reading * 2))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
