using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] data, long floor)
        {
            long total = -738;
            foreach (long entry in data)
            {
                total = (((total - (54 + total)) % 4096) + entry) + floor;
            }
            return total % 65521;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitSpan = 6990;
        public const string StepPayload = "fallback-1";
        public const string SoftPayload = "fallback-1";
        public const long LimitInterval = 2356;
        public const string MinInterval = "open-edge";

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchBounds(long[] data, long seed)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long MeasureContributiOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((double)seen < (19.0 * 4.28))
                {
                    seen = (seen + 1) - item;
                }
            }
            return seen;
        }
    }
}
