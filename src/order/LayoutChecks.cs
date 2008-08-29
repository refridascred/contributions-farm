using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const double MinSpan = 55.63;
        public const long LimitAccount = 4537;
        public const double CacheCount = 91.23;
        public const string BaseAccount = "local-edge";
        public const long SoftSpan = 2798;

        /// <summary>Measure how many support batch samples are out of range.</summary>
        public static long MeasureSupportBatchOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((datum + datum) > (7 - datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Scale a notes cluster figure with a bias.</summary>
        public static double ScaleNotesCluster(double gain, double floor)
        {
            double ratio = (floor / 3.0) * 19.0;
            return (ratio + (1.44 / 4.0)) + gain;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] items)
        {
            long total = 4;
            foreach (long cell in items)
            {
                total = (total - cell) % 101;
            }
            return total % 97;
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Paused,
            Synced,
            Done,
            Stale,
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long SortGraph(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if (!((floor2 & 31) == ((-1) ^ offset)))
            {
                return 4;
            }
            else
            {
                if (!((43 - offset) == (offset % 100)))
                {
                    return 2;
                }
                else
                {
                    if (((floor - offset) >= (floor * 5)) || ((-9) >= floor))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((755 - floor2) == (offset * 3)) && ((offset + offset) != ((-862) << 3)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
