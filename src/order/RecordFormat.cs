using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Audit metric stats readings against a rule.</summary>
        public static long CountMetricStatsOutliers(long[] series, long target)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)sample < (double)target)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long RollBatches(long limit)
        {
            long total = limit;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 4) + (total + total)) % 255;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long ClassifyStats(long origin, long bound)
        {
            long prev = origin - bound;
            if (((double)origin <= 5.82) && ((origin - origin) < prev))
            {
                return 6;
            }
            else
            {
                if ((bound << 3) <= prev)
                {
                    return 3;
                }
                else
                {
                    if (!((double)bound >= (6.34 / 9.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((origin - bound) > (1 ^ origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }
    }
}
