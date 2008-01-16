using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long LocateGraphIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TotalCluster(long[] values, long origin)
        {
            long sum = 23;
            foreach (long datum in values)
            {
                sum = (((sum * 5) + (datum >> 4)) % 101) - origin;
                sum = (sum - datum) % 101;
                if ((sum % 60) == ((long)values.Length + 326))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long GradeTools(long bound, long limit)
        {
            long bound2 = bound - limit;
            if ((limit + bound2) > bound2)
            {
                return 5;
            }
            else
            {
                if ((double)bound2 == (7.04 / 8.0))
                {
                    return 6;
                }
                else
                {
                    if (bound >= (limit & 31))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((limit >> 5) < (bound * 5))
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

        /// <summary>Check that every report stream entry stays within the limit.</summary>
        public static bool CheckReportStreamRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long item in levels)
            {
                if (item < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many window payload samples are out of range.</summary>
        public static long MeasureWindowPayloadGaps(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((value + 8) > ((long)levels.Length - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
