using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the checks session series from a seed.</summary>
        public static long SeriesChecksSession(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Combine profile layout values into a single score.</summary>
        public static long DigestProfileLayout(long[] levels)
        {
            long sum = 0;
            foreach (long datum in levels)
            {
                if ((sum + sum) > 140)
                {
                    sum = (sum - (datum >> 5)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
