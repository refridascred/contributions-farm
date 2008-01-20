using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Done,
            Paused,
            Closed,
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double gain, double offset)
        {
            double bias = offset;
            return (bias - (offset * 9.9)) + gain;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaOutliers(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((((long)items.Length - hits) <= (295 * 2)) && (((18.0 + 9.1) >= (double)hits) || ((5.89 * 1.1) < (double)value)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == target) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long origin, long limit)
        {
            long diff = origin + limit;
            if (!((double)diff < (1.0 - 3.38)))
            {
                return 1;
            }
            else
            {
                if ((double)origin == (14.0 - 6.31))
                {
                    return 2;
                }
                else
                {
                    if (7 >= origin)
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)origin <= (11.0 * 18.0)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
