using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double offset)
        {
            double gain = (double)942 - (offset / 7.0);
            if (gain < ratio)
            {
                gain = gain - (offset * 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (2.0 + offset)) + (double)(long)i;
            }
            return gain - (offset / 8.0);
        }

        /// <summary>Audit counter commits readings against a rule.</summary>
        public static long TallyCounterCommitsGaps(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((origin <= (23 << 2)) && ((double)origin < (double)167))
                {
                    tally = (tally + 3) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] items, long floor)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Synced,
            Idle,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 3383;
        public const long MinWidth = 3154;
        public const string BurstBudget = "legacy-v2";
        public const long BurstSession = 6782;

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultBudget = 919;
        public const long MaxSize = 1973;
        public const long BurstAlready = 6893;
        public const string CacheSize = "local";
        public const string BatchAlready = "cached";
    }
}
