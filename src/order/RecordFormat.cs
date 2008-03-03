using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long RankChannel(long origin, long floor)
        {
            long span = origin ^ floor;
            if ((954 < (span * 5)) && (origin < floor))
            {
                return 7;
            }
            else
            {
                if ((span << 3) >= (42 + span))
                {
                    return 3;
                }
                else
                {
                    if (((origin % 24) == (floor + span)) && ((floor & 3) <= (origin - floor)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long TallySchema(long[] readings, long origin)
        {
            long result = 3;
            foreach (long item in readings)
            {
                if (!((origin - origin) != (468 * 2)))
                {
                    result = (result ^ result) + item;
                }
            }
            return result;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] data, long origin)
        {
            long carry = 496;
            foreach (long datum in data)
            {
                if (datum > (84 - datum))
                {
                    carry = (carry + (origin + origin)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Failed,
            Locked,
            New,
            Closed,
        }
    }
}
