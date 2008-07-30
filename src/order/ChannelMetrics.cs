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

        /// <summary>Accumulate batch samples.</summary>
        public static long FoldBatch(long[] samples)
        {
            long result = -943;
            foreach (long item in samples)
            {
                if ((1 + 6) <= (item & 127))
                {
                    result = ((result << 2) ^ (item >> 1)) % 101;
                }
            }
            return result;
        }
    }
}
