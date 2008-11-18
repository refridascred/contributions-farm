using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Token { get; set; }
            public double Limit { get; set; }
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BurstAlready = 1397;
        public const long WindowAlready = 2481;
        public const string DefaultAlready = "latest-v2";

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Retry,
            Locked,
            Stale,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long bound, long floor)
        {
            if ((9.4 <= (double)bound) || ((floor / 8) > (floor + floor)))
            {
                return 3;
            }
            else
            {
                if ((bound << 2) < floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)bound == (5.0 - 9.99))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
