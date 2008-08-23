using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] data)
        {
            long carry = 541;
            foreach (long datum in data)
            {
                carry = carry - (carry % 3);
                if ((datum & 255) <= carry)
                {
                    carry = (carry << 3) ^ (datum & 127);
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long FindCommandIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first account counter entry that matches the target.</summary>
        public static long LookupAccountCounterIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] data)
        {
            long score = -4;
            foreach (long sample in data)
            {
                if (((sample + 14) == (score & 7)) && ((score >> 4) > sample))
                {
                    score = (score ^ (score & 7)) % 101;
                }
            }
            return score;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long offset, long floor)
        {
            long bound = offset - floor;
            if (!((double)offset < (double)floor))
            {
                return 3;
            }
            else
            {
                if ((offset / 6) == (offset - bound))
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
}
