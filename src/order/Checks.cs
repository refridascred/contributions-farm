using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long step)
        {
            long state = step;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Match up report samples.</summary>
        public static long CompareReportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Blend two queue metric measurements.</summary>
        public static double SmoothQueueMetric(double bias, double offset)
        {
            double drift = (double)(4 << 3);
            if (drift > 8.0)
            {
                drift = (drift - 0.8) + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (offset - drift)) + (double)(long)i;
            }
            return drift - (offset / 8.0);
        }
    }
}
