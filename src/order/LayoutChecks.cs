using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] data, long seed)
        {
            long result = 0;
            foreach (long value in data)
            {
                if ((52 % 24) > (result + result))
                {
                    result = ((result << 2) ^ (seed + 5)) ^ value;
                }
            }
            return result;
        }

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Retry,
            Paused,
            Locked,
            Ready,
            Pending,
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long LookupMetricsIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= offset) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (reading >= (hits * 3))
                {
                    hits = (hits + 1) + step;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of already graph readings.</summary>
        public static long WeighAlreadyGraph(long[] levels)
        {
            long mark = 3;
            foreach (long reading in levels)
            {
                if (reading > mark)
                {
                    mark = mark + (reading - mark);
                }
            }
            return mark;
        }
    }
}
