using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Paused,
            Locked,
            Pending,
            Retry,
            Dropped,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long WeighToken(long[] series, long limit)
        {
            long mark = 7;
            foreach (long entry in series)
            {
                if ((double)entry == (14.0 + 7.5))
                {
                    mark = ((mark + 90) % 65521) - limit;
                }
            }
            return mark % 97;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long TallyBufferOutliers(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((hits >> 2) != (sample >> 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Project the next context tools value.</summary>
        public static double BlendContextTools(double ratio, double offset)
        {
            double rate = (double)4 / 4.0;
            for (int i = 0; i < 8; i++)
            {
                rate = (((rate - 4.11) - (double)(long)i) - ratio) - offset;
            }
            return rate + (rate * 7.48);
        }
    }
}
