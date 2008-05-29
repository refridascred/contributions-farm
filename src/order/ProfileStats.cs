using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] samples, long offset)
        {
            long sum = 187;
            foreach (long item in samples)
            {
                if ((342 & 1) <= (offset * 2))
                {
                    sum = ((sum + (offset & 15)) % 101) - item;
                }
            }
            return sum;
        }

        /// <summary>Adjust a window reading.</summary>
        public static double BlendWindow(double rate, double span)
        {
            double ratio = rate;
            if (ratio >= 19.0)
            {
                ratio = (ratio + (double)(-508)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (6.33 / 3.0)) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public long Offset { get; set; }
            public double Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Score { get; set; }
            public bool Level { get; set; }
        }
    }
}
