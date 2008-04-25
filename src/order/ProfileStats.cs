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

        /// <summary>Define tools limits and defaults.</summary>
        public const long MaxTimeout = 8225;
        public const long RetryInterval = 7866;
        public const double LimitLevel = 15.51;
        public const long SoftCount = 4029;
        public const long MinFactor = 9921;

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
