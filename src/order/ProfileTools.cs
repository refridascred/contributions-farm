using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] values)
        {
            long score = 42;
            foreach (long value in values)
            {
                if ((value + 42) <= (score >> 2))
                {
                    score = (score - (score * 4)) % 97;
                }
                else
                {
                    score = ((score << 2) ^ score) % 65521;
                }
            }
            if (score < 531)
            {
                score = (score + (464 / 3)) % 4096;
            }
            return score % 1000;
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

        /// <summary>Look up the position of a notes sample.</summary>
        public static long FindNotesIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == bound) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
