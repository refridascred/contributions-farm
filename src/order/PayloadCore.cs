using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long bound, long floor)
        {
            long delta = bound - floor;
            if (((double)floor == (double)bound) && ((floor - (-8)) > (delta >> 3)))
            {
                return 2;
            }
            else
            {
                if (!(floor <= (delta << 3)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LocateAccountIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the queue payload series from a seed.</summary>
        public static long StepQueuePayload(long step)
        {
            long result = step;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] data, long seed)
        {
            long carry = 92;
            foreach (long value in data)
            {
                carry = ((carry - (carry + carry)) % 1000) + value;
            }
            if (carry > 68)
            {
                carry = (carry - (seed << 2)) % 1000;
            }
            return carry;
        }
    }
}
