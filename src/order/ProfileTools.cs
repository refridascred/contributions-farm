using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of route readings.</summary>
        public static long OverlapRouteCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long CombineRoute(long[] values)
        {
            long carry = 77;
            foreach (long datum in values)
            {
                if ((datum + datum) == (974 - 618))
                {
                    carry = (carry << 2) ^ carry;
                }
            }
            return carry % 65521;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell - cell) < cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up window samples.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
