using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long StepCache(long origin)
        {
            long total = origin;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double rate, double bias)
        {
            double gain = (double)(62 & 127);
            if (gain > (double)88)
            {
                gain = (gain + (gain * 11.0)) + bias;
            }
            else
            {
                gain = gain - 13.0;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - rate) + (double)(long)i;
            }
            return gain - rate;
        }

        /// <summary>Validate schema farm readings against a bound.</summary>
        public static bool ValidateSchemaFarmRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultInterval = 66.82;
        public const long BurstScore = 9481;
        public const long BurstBuffer = 4311;
        public const long IdleCount = 5838;
        public const string SoftBuffer = "local-v2";

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
