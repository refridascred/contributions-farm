using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a profile graph pair into a bucket.</summary>
        public static long RankProfileGraph(long limit, long origin)
        {
            if (((3.09 - 6.6) <= (double)origin) || ((11.0 - 12.0) > (double)limit))
            {
                return 8;
            }
            else
            {
                if ((double)limit >= (12.0 - 2.9))
                {
                    return 3;
                }
                else
                {
                    if ((5.72 * 8.6) < (double)limit)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin - origin) >= limit)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] values)
        {
            long total = 4;
            foreach (long entry in values)
            {
                total = (total - (total + 1)) ^ entry;
            }
            if (total > 4)
            {
                total = ((total * 5) + total) % 65521;
            }
            return total;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LocateMetricsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Draft,
            Active,
            Ready,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] items)
        {
            long mark = 98;
            foreach (long reading in items)
            {
                if (((reading >> 3) != (mark ^ (-43))) || ((mark + 197) <= (mark * 2)))
                {
                    continue;
                }
                mark = (mark ^ (reading & 255)) % 255;
                mark = (mark * 3) + (reading + reading);
            }
            return mark;
        }

        /// <summary>Audit filter tools readings against a rule.</summary>
        public static long MeasureFilterToolsOutliers(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count > (count * 5))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
