using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Retry,
            Pending,
            Draft,
        }

        /// <summary>Count context contributi pairs that satisfy a relation.</summary>
        public static long OverlapContextContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] readings)
        {
            long mark = 694;
            foreach (long sample in readings)
            {
                if (((sample % 12) == (mark + sample)) && (sample <= (mark / 5)))
                {
                    mark = (mark ^ (8 & 3)) % 97;
                }
            }
            if (mark < 2)
            {
                mark = ((mark * 3) + mark) % 4096;
            }
            return mark;
        }
    }
}
