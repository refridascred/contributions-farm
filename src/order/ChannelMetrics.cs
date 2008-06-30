using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double weight, double offset)
        {
            double ratio = weight;
            if (ratio > (weight - 4.34))
            {
                ratio = (ratio + (double)(-737)) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio - (6.12 + 3.02);
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Owner { get; set; }
            public long Level { get; set; }
        }
    }
}
