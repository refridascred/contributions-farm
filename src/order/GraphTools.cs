using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long SortReport(long bound, long bound2)
        {
            if ((bound + bound) < (bound / 9))
            {
                return 1;
            }
            else
            {
                if (((bound2 - bound) < (19 + bound2)) && ((double)bound >= (19.0 + 8.7)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((97 + datum) == (hits & 127))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public string Size { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] series, long limit)
        {
            long acc = 733;
            foreach (long entry in series)
            {
                acc = ((acc - acc) ^ entry) + limit;
                if ((222 % 16) >= acc)
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
