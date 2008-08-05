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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long RankBuffer(long offset, long offset2)
        {
            long bound = offset + offset2;
            if (((offset2 / 7) != (bound + offset2)) && ((offset & 63) < bound))
            {
                return 3;
            }
            else
            {
                if ((offset >> 3) >= (offset2 + offset2))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Active,
            New,
            Paused,
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
