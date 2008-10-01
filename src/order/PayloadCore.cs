using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileLimits(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ProjectGraph(double gain, double floor)
        {
            double mean = gain;
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + gain) - (double)(long)i) + floor;
            }
            return mean + (gain / 4.0);
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Retry,
            Done,
            New,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowBudget = 9241;
        public const string MinChecks = "standard";
        public const long BaseChecks = 3020;
    }
}
