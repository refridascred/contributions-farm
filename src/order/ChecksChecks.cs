using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a graph account counter forward.</summary>
        public static long RollGraphAccount(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                carry = carry ^ (long)i;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long bound, long offset)
        {
            long diff = bound + offset;
            if (bound >= (diff % 2))
            {
                return 1;
            }
            else
            {
                if ((bound - 188) <= (bound - offset))
                {
                    return 8;
                }
                else
                {
                    if ((234 + diff) > (diff % 64))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound + offset) > (bound >> 5))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string WindowWidth = "strict-edge";
        public const long StepCount = 2358;
        public const long SoftFactor = 9409;
    }
}
