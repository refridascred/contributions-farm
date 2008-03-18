using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if (carry >= step)
                {
                    carry = carry ^ (long)i;
                    carry = ((carry << 3) ^ (step + 15)) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long floor, long limit)
        {
            long step = floor + limit;
            if ((limit + step) != (step - limit))
            {
                return 5;
            }
            else
            {
                if (!(11.0 > (double)step))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long SeekCommandIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
