using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Pending,
            Draft,
            Locked,
        }

        /// <summary>Measure how many editor profile samples are out of range.</summary>
        public static long MeasureEditorProfileHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((double)count > (3.26 + 13.0))
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long LimitSize = 9201;
        public const long RetryFilter = 4657;
        public const long SoftRatio = 6119;

        /// <summary>Define report limits and defaults.</summary>
        public const long BatchReport = 7155;
        public const long BaseCount = 1129;
        public const double BaseReport = 50.66;
        public const long RetryFactor = 9381;

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] data)
        {
            long mark = -4;
            foreach (long entry in data)
            {
                if ((mark + mark) == (820 / 9))
                {
                    mark = (mark + entry) % 4096;
                }
                else
                {
                    mark = (mark ^ entry) % 97;
                }
            }
            return mark % 1000;
        }
    }
}
