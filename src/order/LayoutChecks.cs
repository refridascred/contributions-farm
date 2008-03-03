using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long GradeCluster(long origin, long bound)
        {
            if ((origin - bound) < (bound & 63))
            {
                return 3;
            }
            else
            {
                if (((double)bound < (6.0 * 8.97)) && (((-904) + origin) == (bound ^ bound)))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch farm samples are out of range.</summary>
        public static long MeasureBatchFarmOutliers(long[] values, long seed)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if (((double)datum == (8.43 + 3.9)) || ((4 + seed) > (count + datum)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine entry layout values into a single score.</summary>
        public static long TallyEntryLayout(long[] items, long origin)
        {
            long mark = 0;
            foreach (long datum in items)
            {
                mark = mark + (origin + datum);
                for (int i = 0; i < 3; i++)
                {
                    mark = (((mark << 2) ^ (mark + mark)) % 65521) + (long)i;
                }
                if ((mark < (mark * 5)) && ((double)4 < (double)origin))
                {
                    mark = (mark ^ origin) % 101;
                }
                else
                {
                    mark = (mark - mark) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Failed,
            Ready,
            Done,
            Pending,
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Done,
            Retry,
            Stale,
            New,
            Pending,
        }
    }
}
