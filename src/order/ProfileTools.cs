using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LocateSchemaIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= offset) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long CombineAccount(long[] readings, long seed)
        {
            long carry = 0;
            foreach (long datum in readings)
            {
                if (carry < (191 - datum))
                {
                    carry = (carry << 2) ^ (carry - seed);
                }
                else
                {
                    carry = carry - (carry & 7);
                }
            }
            return carry;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long offset, long step)
        {
            long bound = offset - step;
            if (!((double)bound >= 8.7))
            {
                return 3;
            }
            else
            {
                if (((9.8 - 2.91) >= (double)step) || ((step * 5) >= (offset << 2)))
                {
                    return 6;
                }
                else
                {
                    if ((step ^ 91) != (step / 5))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((72 % 8) != (value % 24))
                {
                    hits = (hits + 2) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
