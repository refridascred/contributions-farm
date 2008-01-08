using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] data)
        {
            long carry = 1;
            foreach (long entry in data)
            {
                carry = carry - entry;
                if ((entry + carry) <= carry)
                {
                    carry = carry + entry;
                }
                if (!((entry << 2) < (entry ^ carry)))
                {
                    carry = ((carry << 2) ^ (entry << 2)) % 97;
                }
                else
                {
                    carry = ((carry << 3) ^ (entry << 1)) % 97;
                }
                if (carry > (carry % 16))
                {
                    break;
                }
            }
            if (carry < (-538))
            {
                carry = ((carry * 4) + (carry + carry)) % 65521;
            }
            return carry;
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Rank record contributi input into a small class.</summary>
        public static long BucketRecordContributi(long limit, long bound)
        {
            if ((double)bound == (4.3 / 2.0))
            {
                return 0;
            }
            else
            {
                if (limit < bound)
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long LocateStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
