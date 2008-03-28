using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long TallyChecks(long[] readings, long bound)
        {
            long state = 1;
            foreach (long sample in readings)
            {
                state = state + (bound % 5);
                if ((sample * 5) <= (state << 3))
                {
                    state = state ^ ((-6) + sample);
                }
                else
                {
                    state = (state - (sample * 4)) % 101;
                }
            }
            return state;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Mode { get; set; } = "";
            public string Token { get; set; } = "";
            public string Level { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 6794;
        public const double HardCount = 8.45;
        public const long StepRoute = 8430;
        public const long CacheWidth = 3509;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowBatch = 9015;
        public const long DefaultBudget = 231;
        public const long SoftBatch = 7542;
        public const long StepTimeout = 2706;

        /// <summary>Hold a support stats.</summary>
        public sealed class SupportStats
        {
            public long Rank { get; set; }
            public double Ratio { get; set; }
        }
    }
}
