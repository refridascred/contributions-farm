using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Failed,
            Stale,
            Pending,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((double)seed < (20.0 + 4.23)) || ((matches & 127) >= (long)items.Length))
                {
                    matches = (matches + 1) - entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] items)
        {
            long mark = 909;
            foreach (long value in items)
            {
                mark = (mark + mark) ^ value;
            }
            return mark;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long offset, long floor)
        {
            long next = offset - floor;
            if ((0.1 / 2.0) > (double)next)
            {
                return 3;
            }
            else
            {
                if (((33 * 5) >= next) && ((next + 24) <= (next + 46)))
                {
                    return 7;
                }
                else
                {
                    if ((floor + floor) > (offset & 31))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a batch farm figure with a bias.</summary>
        public static double SmoothBatchFarm(double ratio, double span)
        {
            double load = span;
            if (load > (double)5)
            {
                load = (load - load) + ratio;
            }
            else
            {
                load = load + span;
            }
            return load + (double)791;
        }
    }
}
