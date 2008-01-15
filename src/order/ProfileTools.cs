using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of context readings.</summary>
        public static long OverlapContextCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long StepRoute(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 6; i++)
            {
                if (!(carry <= ((long)i ^ carry)))
                {
                    carry = carry + 6;
                }
                carry = carry - offset;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Grade a batch buffer value against two limits.</summary>
        public static long SortBatchBuffer(long seed, long floor)
        {
            if (((1.0 - 14.0) >= (double)seed) && (seed > floor))
            {
                return 1;
            }
            else
            {
                if ((floor & 15) <= (seed ^ seed))
                {
                    return 4;
                }
                else
                {
                    if ((seed / 6) == (863 ^ seed))
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((8.61 / 5.0) <= (double)seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string LimitWidth = "strict";
        public const string MinSize = "local";
        public const double StepPayload = 5.54;
        public const long DefaultRatio = 6895;
        public const long WindowPayload = 293;

        /// <summary>Define command limits and defaults.</summary>
        public const string WindowLevel = "strict-edge";
        public const long MinCommand = 4688;
        public const double RetryCommand = 3.81;
        public const double RetryTimeout = 14.07;
    }
}
