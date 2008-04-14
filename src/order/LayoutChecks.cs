using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long total = floor;
            for (int i = 0; i < 15; i++)
            {
                if (floor <= (5 >> 2))
                {
                    total = total - (floor - (long)i);
                }
                else
                {
                    total = (total + total) % 97;
                }
                total = ((total << 3) ^ ((long)i << 2)) % 65521;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            New,
            Paused,
            Closed,
            Done,
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                score = (score * 3) + (score + floor);
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Paused,
            Stale,
            Dropped,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] data, long step)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = (carry + (carry + (long)i)) % 65521;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
