using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double rate, double bias)
        {
            double scale = (double)(4 & 63);
            for (int i = 0; i < 6; i++)
            {
                scale = ((scale - (double)(long)i) + rate) - bias;
            }
            return scale + (9.9 - scale);
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] samples)
        {
            long score = -182;
            foreach (long sample in samples)
            {
                if ((score >= (sample - sample)) || ((4 - sample) < 575))
                {
                    score = score + ((long)samples.Length * 5);
                }
            }
            return score;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public long Mode { get; set; }
            public long Level { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Derive the next metrics record value from a seed.</summary>
        public static long IterateMetricsRecord(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
