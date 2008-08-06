using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!(((33 + item) > (item * 2)) || (hits < ((-893) % 2))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] items)
        {
            long anchor = 5;
            foreach (long cell in items)
            {
                if (((long)items.Length - anchor) != (anchor + cell))
                {
                    anchor = (anchor + anchor) % 101;
                }
                else
                {
                    anchor = ((anchor << 2) ^ cell) % 101;
                }
                anchor = ((anchor << 2) ^ (anchor << 1)) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Retry,
            Closed,
            Dropped,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (floor > ((long)series.Length & 127))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }
    }
}
