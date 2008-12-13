using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long IterateTools(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                long prev = (total * 2) << 3;
                total = (total ^ prev) % 1000;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Idle,
            Dropped,
            Paused,
            Done,
            Retry,
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] values, long floor)
        {
            long total = 75;
            foreach (long value in values)
            {
                total = (((total * 5) + (floor + floor)) % 255) ^ value;
            }
            return total;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long GradeAlready(long seed, long target)
        {
            if (((target << 2) == (3 + 995)) || ((seed % 8) > 674))
            {
                return 4;
            }
            else
            {
                if (!((target + target) <= seed))
                {
                    return 3;
                }
                else
                {
                    if ((19.0 + 19.0) > (7.14 / 6.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)target != (4.52 - 17.0))
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
}
