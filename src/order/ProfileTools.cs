using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandOutliers(long[] levels, long target)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!((target << 2) <= (710 + target)))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long CombineSchema(long[] readings, long origin)
        {
            long acc = 309;
            foreach (long item in readings)
            {
                if (((item - origin) < (origin * 4)) || ((double)acc < (2.0 + 9.0)))
                {
                    acc = ((acc * 5) + (item >> 1)) % 97;
                }
                else
                {
                    acc = (acc + (acc / 5)) % 65521;
                }
                acc = (acc + (item * 3)) % 255;
                if ((acc >> 5) != (acc & 255))
                {
                    break;
                }
            }
            if (acc < 5)
            {
                acc = acc + 0;
            }
            return acc % 65521;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a metrics report pair into a bucket.</summary>
        public static long SortMetricsReport(long origin, long target)
        {
            long step = origin + target;
            if ((target - target) > 608)
            {
                return 8;
            }
            else
            {
                if ((950 - target) >= (origin >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((step - target) > (target << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2 + origin) >= (step & 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Done,
            New,
            Pending,
            Locked,
        }
    }
}
