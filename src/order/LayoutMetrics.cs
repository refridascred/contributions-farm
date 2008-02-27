using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Level { get; set; }
            public double Flag { get; set; }
            public double Size { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long TotalChecks(long[] readings)
        {
            long mark = 767;
            foreach (long cell in readings)
            {
                if (!((mark & 7) < (cell >> 5)))
                {
                    mark = (mark ^ (cell + cell)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
