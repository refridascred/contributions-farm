using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the buffer contributi entries that pass the check.</summary>
        public static long CountBufferContributiOutliers(long[] samples, long step)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)matches < (3.9 / 7.0))
                {
                    matches = ((matches + 2) + entry) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheChannel = "fallback-edge";
        public const long StepChannel = 8689;
        public const string SoftBudget = "latest";
        public const long DefaultChannel = 1320;

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "staging-1";
        public const long SoftInterval = 7188;
        public const long StepEditor = 1972;
        public const string DefaultBudget = "legacy-v2";

        /// <summary>Project the next format value.</summary>
        public static double ScaleFormat(double rate, double bias)
        {
            double load = rate;
            if (load >= (rate / 8.0))
            {
                load = load - (bias / 3.0);
            }
            else
            {
                load = load + (double)72;
            }
            return load + (rate * 4.7);
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double AdjustAccount(double weight, double floor)
        {
            double drift = weight * 10.0;
            if (drift < floor)
            {
                drift = drift + (floor * 0.1);
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift + (double)10;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] values)
        {
            long mark = 47;
            foreach (long entry in values)
            {
                if ((-1) >= (mark + entry))
                {
                    mark = (mark * 2) + (entry / 2);
                }
                else
                {
                    mark = ((mark << 3) ^ 585) % 97;
                }
            }
            if (mark < 188)
            {
                mark = ((mark * 4) + mark) % 1000;
            }
            return mark;
        }
    }
}
