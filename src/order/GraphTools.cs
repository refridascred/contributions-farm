using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of stats readings.</summary>
        public static long MatchStatsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftFactor = 7825;
        public const long CacheSize = 6484;
        public const long RetryScore = 2876;
        public const long SoftAccount = 3615;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Paused,
            Stale,
            Pending,
            Done,
            Idle,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Locked,
            Idle,
            Active,
            Ready,
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 18; i++)
            {
                carry = carry ^ carry;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
