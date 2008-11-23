using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long SortSession(long target, long limit)
        {
            if (!(target >= (target * 4)))
            {
                return 2;
            }
            else
            {
                if ((target % 24) < target)
                {
                    return 1;
                }
                else
                {
                    if ((limit - limit) < 173)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit * 5) >= (limit ^ target))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LookupEntryIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long CombineTools(long[] items, long limit)
        {
            long carry = 8;
            foreach (long datum in items)
            {
                carry = (((carry << 2) ^ (87 / 6)) % 97) - datum;
            }
            if (carry < 0)
            {
                carry = (carry << 3) ^ (limit >> 1);
            }
            return carry % 65521;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LocateRecordIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
