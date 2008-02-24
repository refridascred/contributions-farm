using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextMatches(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((6.9 - 9.1) >= (double)hits)
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] values, long step)
        {
            long state = 50;
            foreach (long sample in values)
            {
                if (((sample << 1) > (4 / 7)) || ((step / 8) > state))
                {
                    state = (state ^ ((long)values.Length * 5)) % 1000;
                }
            }
            return state % 1000;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 18.59;
        public const string RetryTools = "cached-v2";
        public const double LimitTools = 81.73;
        public const double IdleSize = 66.39;
        public const long HardTools = 9289;

        /// <summary>Project the next batches value.</summary>
        public static double ScaleBatches(double gain, double bias)
        {
            double drift = bias;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift + (drift * 2.68)) + (double)(long)i) - gain;
            }
            return drift + (16.0 * 16.0);
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Weight { get; set; }
            public string Limit { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
