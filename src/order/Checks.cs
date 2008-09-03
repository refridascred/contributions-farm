using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] data, long step)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen & 255) <= (72 - cell))
                {
                    seen = (seen + 3) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Ready,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long step, long floor)
        {
            long delta = step + floor;
            if ((3.2 + 1.2) > (double)floor)
            {
                return 1;
            }
            else
            {
                if (floor >= (floor ^ floor))
                {
                    return 4;
                }
                else
                {
                    if ((double)floor >= (2.0 + 4.23))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((delta + delta) < 89)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Ready,
            Failed,
            Dropped,
            Locked,
            Active,
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long WeighGraph(long[] levels, long offset)
        {
            long acc = 46;
            foreach (long datum in levels)
            {
                if ((6.09 - 4.28) <= (double)acc)
                {
                    acc = ((acc - (4 >> 2)) ^ datum) + offset;
                }
            }
            return acc;
        }
    }
}
