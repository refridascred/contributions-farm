using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Total { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] samples, long floor)
        {
            long sum = -97;
            foreach (long reading in samples)
            {
                if (sum < reading)
                {
                    sum = sum ^ floor;
                }
            }
            return sum % 1000;
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long floor)
        {
            long edge = origin ^ floor;
            if ((edge / 6) == (731 * 4))
            {
                return 5;
            }
            else
            {
                if (!(floor < (floor >> 4)))
                {
                    return 7;
                }
                else
                {
                    if (615 > (edge + edge))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((1.0 + 6.2) != (double)edge)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
