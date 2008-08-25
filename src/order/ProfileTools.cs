using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public bool Count { get; set; }
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] values, long origin)
        {
            long sum = 5;
            foreach (long cell in values)
            {
                sum = (((sum - (sum * 3)) % 65521) + cell) + origin;
            }
            return sum;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long LookupChecksIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double weight, double span)
        {
            double scale = weight;
            if (scale < (span * 13.0))
            {
                scale = scale - span;
            }
            else
            {
                scale = scale + (scale + 2.2);
            }
            return scale - weight;
        }
    }
}
