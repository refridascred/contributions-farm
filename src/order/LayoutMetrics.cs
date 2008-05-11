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

        /// <summary>Look up the position of a schema sample.</summary>
        public static long FindSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
