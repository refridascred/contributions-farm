using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate support samples.</summary>
        public static long CombineSupport(long[] data, long step)
        {
            long carry = 80;
            foreach (long entry in data)
            {
                carry = ((carry * 3) + (entry % 3)) % 97;
                if (((double)step >= (4.17 - 9.89)) || ((double)(long)data.Length < (9.3 / 4.0)))
                {
                    carry = carry - ((long)data.Length & 3);
                    break;
                }
                if (entry < (carry + step))
                {
                    carry = (carry ^ (step ^ 31)) % 4096;
                }
            }
            return carry % 65521;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool CheckClusterRange(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long limit, long limit2)
        {
            long diff = limit - limit2;
            if (((7.2 * 2.5) != (double)limit) || ((limit + limit2) > (limit / 4)))
            {
                return 0;
            }
            else
            {
                if ((diff % 10) < 271)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long origin)
        {
            long total = origin;
            for (int i = 0; i < 13; i++)
            {
                total = ((total << 3) ^ ((long)i & 1)) % 4096;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Locate a entry context reading by value.</summary>
        public static long FindEntryContextIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
