using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelOutliers(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (hits <= (datum + bound))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long mark = 455;
            foreach (long entry in items)
            {
                if ((3.9 + 20.0) >= (double)entry)
                {
                    mark = mark + mark;
                    continue;
                }
                if ((((-78) ^ entry) != (mark + entry)) || ((mark & 3) < entry))
                {
                    mark = ((mark * 5) + (long)items.Length) % 4096;
                }
            }
            return mark % 4096;
        }

        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public string Score { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string SoftFilter = "open-edge";
        public const string CacheRatio = "fallback-1";
        public const long StepFilter = 2618;

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] readings)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                result = ((result << 2) ^ (cell << 3)) % 101;
            }
            if (result > 17)
            {
                result = result + (result & 3);
            }
            return result;
        }
    }
}
