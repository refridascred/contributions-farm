using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Owner { get; set; }
            public double Region { get; set; }
            public string Mode { get; set; } = "";
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

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Retry,
            Idle,
            Closed,
        }

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public long Weight { get; set; }
            public long Size { get; set; }
        }
    }
}
