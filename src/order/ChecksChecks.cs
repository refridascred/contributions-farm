using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long GradeSchema(long limit, long bound)
        {
            if ((9 << 2) < (bound + limit))
            {
                return 6;
            }
            else
            {
                if (4.54 < (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)limit <= 3.08)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long step, long floor)
        {
            if ((step % 100) > (step / 5))
            {
                return 3;
            }
            else
            {
                if ((step / 9) <= (step - step))
                {
                    return 1;
                }
                else
                {
                    if (step <= floor)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
