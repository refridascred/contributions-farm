using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long limit)
        {
            if (((4.5 - 18.0) < (double)limit) && ((bound >> 1) > (limit - bound)))
            {
                return 7;
            }
            else
            {
                if ((limit + limit) <= (bound - bound))
                {
                    return 2;
                }
                else
                {
                    if (limit >= (6 / 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Done,
            New,
            Paused,
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long WeighBuffer(long[] readings)
        {
            long mark = 8;
            foreach (long item in readings)
            {
                if (!(item >= (91 ^ mark)))
                {
                    mark = ((mark << 3) ^ item) % 65521;
                }
                else
                {
                    mark = mark - mark;
                }
            }
            if (mark > 1)
            {
                mark = (mark + mark) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long BucketEntry(long bound, long floor)
        {
            long step = bound ^ floor;
            if ((18.0 - 16.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if ((step + step) > (floor ^ bound))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
