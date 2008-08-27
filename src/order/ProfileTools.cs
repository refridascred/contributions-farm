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

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphGaps(long[] items, long step)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (((entry % 3) < (step / 7)) && ((step - 89) == (1 >> 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
