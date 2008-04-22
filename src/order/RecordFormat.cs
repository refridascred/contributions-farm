using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public string Stamp { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultFactor = 35.56;
        public const double BaseScore = 12.27;
        public const long BatchBudget = 8859;

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up queue samples.</summary>
        public static long PairQueueCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a support githubfarm figure with a bias.</summary>
        public static double ScaleSupportGithubfarm(double scale, double offset)
        {
            double load = scale;
            for (int i = 0; i < 9; i++)
            {
                load = ((load - scale) + (double)(long)i) + offset;
            }
            return load + load;
        }
    }
}
