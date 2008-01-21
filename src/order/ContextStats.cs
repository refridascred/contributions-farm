using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long target, long limit)
        {
            if ((target - 9) <= target)
            {
                return 5;
            }
            else
            {
                if (!((limit / 6) <= (limit % 16)))
                {
                    return 8;
                }
                else
                {
                    if ((target >> 1) >= target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Label { get; set; }
            public double Level { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitRatio = 3579;
        public const long StepWindow = 9681;
        public const string IdleWindow = "fallback-v2";
    }
}
