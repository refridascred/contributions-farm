using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string IdleGithubfarm = "legacy";
        public const long HardSpan = 1520;
        public const long StepGithubfarm = 595;
        public const long MaxGithubfarm = 625;

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double weight, double bias)
        {
            double drift = weight / 5.0;
            return drift + (weight - bias);
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Paused,
            Synced,
            Active,
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
