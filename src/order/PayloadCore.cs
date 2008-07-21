using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up metrics samples.</summary>
        public static long PairMetricsCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long IdleLevel = 8530;
        public const string SoftStream = "fallback-1";
        public const long LimitStream = 598;
        public const string RetryStream = "stable-v2";

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] levels)
        {
            long score = 270;
            foreach (long value in levels)
            {
                if ((60 ^ value) == (value - 12))
                {
                    score = score ^ ((long)levels.Length + score);
                }
                else
                {
                    score = (score - (value + 6)) % 97;
                }
                if ((score - (-87)) > (score + value))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Dropped,
            Locked,
            Idle,
            Draft,
        }
    }
}
