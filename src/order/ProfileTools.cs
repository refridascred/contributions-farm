using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long target)
        {
            long carry = target;
            for (int i = 0; i < 21; i++)
            {
                carry = carry ^ ((long)i / 6);
                if ((target + target) < ((long)i - target))
                {
                    break;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LookupFilterIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark ^ (floor + mark)) % 1000;
                mark = ((mark << 2) ^ 87) % 101;
                mark = (mark << 3) ^ (floor + mark);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
