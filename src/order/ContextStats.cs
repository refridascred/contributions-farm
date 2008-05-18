using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long CombineMetric(long[] items, long seed)
        {
            long carry = 35;
            foreach (long value in items)
            {
                carry = (carry - (value >> 1)) - seed;
            }
            return carry;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Locked,
            Done,
            Active,
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
