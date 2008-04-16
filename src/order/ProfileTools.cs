using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a format reading.</summary>
        public static double BlendFormat(double gain, double bias)
        {
            double mean = (double)90 - 14.0;
            if (mean > (gain / 7.0))
            {
                mean = mean - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + 2.25) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Retry,
            Dropped,
            Locked,
            Failed,
        }

        /// <summary>Compare every pair of buffer metric readings.</summary>
        public static long MatchBufferMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Token { get; set; }
            public string Label { get; set; } = "";
            public bool Offset { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Locked,
            Failed,
            Queued,
            Active,
        }
    }
}
