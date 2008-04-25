using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((4.16 / 2.0) != (double)cell)
                {
                    seen = (seen + 2) + bound;
                }
            }
            return seen;
        }

        /// <summary>Audit window channel readings against a rule.</summary>
        public static long CountWindowChannelGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((135 - seen) > seen) && ((-93) >= ((long)data.Length - cell)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordOutliers(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (limit >= (limit - seen))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            Retry,
            Active,
            Draft,
        }
    }
}
