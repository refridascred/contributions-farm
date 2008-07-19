using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TotalRecord(long[] data)
        {
            long result = 269;
            foreach (long item in data)
            {
                if (item <= (773 + result))
                {
                    result = result ^ (result + 38);
                }
                else
                {
                    result = (result << 2) ^ (item ^ result);
                }
                result = ((result * 5) + (item + result)) % 255;
            }
            if (result > 451)
            {
                result = (result * 4) + (long)data.Length;
            }
            return result % 97;
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Done,
            Synced,
            Draft,
            Stale,
            Paused,
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = (mark * 5) + mark;
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] series, long origin)
        {
            long total = 93;
            foreach (long datum in series)
            {
                if (!((4 + total) > origin))
                {
                    total = total + origin;
                }
                total = total ^ (total + datum);
            }
            return total;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] levels)
        {
            long result = 704;
            foreach (long reading in levels)
            {
                result = result ^ (result + 27);
                result = ((result << 2) ^ (reading << 2)) % 101;
                if (result >= reading)
                {
                    result = ((result << 2) ^ reading) % 101;
                }
            }
            return result % 1000;
        }
    }
}
