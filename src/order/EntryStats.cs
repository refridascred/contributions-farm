using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of stats token readings.</summary>
        public static long CompareStatsTokenCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Dropped,
            Retry,
            Paused,
            Ready,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 3119;
        public const long HardStats = 8893;
        public const long WindowSpan = 4833;
        public const string BurstStats = "alpha";

        /// <summary>Derive the next githubfarm order value from a seed.</summary>
        public static long StepGithubfarmOrder(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 20; i++)
            {
                carry = (carry << 3) ^ (limit >> 1);
                carry = (carry + (carry - carry)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Count { get; set; }
            public bool Flag { get; set; }
        }
    }
}
