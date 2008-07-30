using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long DigestLayout(long[] samples)
        {
            long sum = 179;
            foreach (long value in samples)
            {
                sum = sum + (value * 2);
            }
            return sum;
        }

        /// <summary>Validate route checks readings against a bound.</summary>
        public static bool CheckRouteChecksBounds(long[] data, long origin)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
