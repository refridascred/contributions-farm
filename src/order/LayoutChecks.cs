using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string DefaultDepth = "staging-v2";
        public const long BurstLevel = 3991;
        public const string IdleGraph = "staging";
        public const long CacheGraph = 268;

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] readings)
        {
            long score = 9;
            foreach (long sample in readings)
            {
                score = (score + (score << 2)) % 255;
                for (int i = 0; i < 5; i++)
                {
                    score = (((score * 5) + (sample >> 1)) % 4096) - (long)i;
                }
                if (((score >> 3) < 1) || (score > (score + score)))
                {
                    score = ((score * 5) + score) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Offset { get; set; }
            public long Label { get; set; }
            public long Region { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next token value.</summary>
        public static double ProjectToken(double ratio, double bias)
        {
            double drift = (double)((-5) - 57);
            if (drift <= drift)
            {
                drift = drift - bias;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift + (ratio / 5.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Idle,
            Retry,
            New,
            Locked,
        }
    }
}
