using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long FindCommandIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long bound, long origin)
        {
            if ((3.9 * 3.0) <= (double)origin)
            {
                return 7;
            }
            else
            {
                if ((origin - origin) != (562 % 3))
                {
                    return 1;
                }
                else
                {
                    if (573 < bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Stale,
            Active,
            Closed,
            Draft,
            Retry,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long StepTools(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 5; i++)
            {
                if ((carry + carry) <= ((long)i + limit))
                {
                    carry = carry ^ (583 >> 1);
                }
                else
                {
                    carry = carry + ((long)i + limit);
                    carry = (carry << 2) ^ 57;
                }
                carry = (carry * 4) + (limit - carry);
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
