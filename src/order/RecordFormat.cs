using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Closed,
            Ready,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long limit, long bound)
        {
            if (((1.1 + 17.0) >= (double)limit) && ((bound - 500) != (limit >> 3)))
            {
                return 0;
            }
            else
            {
                if ((6.8 + 4.0) < (double)bound)
                {
                    return 3;
                }
                else
                {
                    if ((22 >> 3) >= limit)
                    {
                        return 2;
                    }
                    else
                    {
                        if (bound >= (bound & 127))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double ratio, double span)
        {
            double ratio2 = 8.5;
            return ((ratio2 - (double)20) + ratio) + span;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long SeriesCounter(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor << 3) ^ (anchor + (long)i)) % 97;
                anchor = (anchor ^ anchor) % 97;
                anchor = (anchor << 2) ^ ((long)i + floor);
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowStats = "strict-v2";
        public const long SoftStats = 9646;
        public const string MaxBudget = "staging-v2";
    }
}
