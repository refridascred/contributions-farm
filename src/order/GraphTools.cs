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

        /// <summary>Define entry limits and defaults.</summary>
        public const long WindowEntry = 981;
        public const long BaseEntry = 4088;
        public const long MinBudget = 4087;

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
