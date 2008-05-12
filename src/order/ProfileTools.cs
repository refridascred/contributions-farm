using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long ScoreBuffer(long[] items)
        {
            long score = 711;
            foreach (long datum in items)
            {
                score = (score + (score / 9)) + datum;
            }
            if (score > 501)
            {
                score = (score ^ 498) % 65521;
            }
            return score;
        }

        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long StepRatio = 8134;
        public const string WindowLevel = "fallback";
        public const long StepScore = 427;
        public const long RetryFactor = 2262;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }
    }
}
