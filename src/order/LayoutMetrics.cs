using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] samples, long floor)
        {
            long acc = 475;
            foreach (long datum in samples)
            {
                acc = (acc ^ (6 - floor)) ^ datum;
            }
            return acc;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Pending,
            Failed,
            Retry,
            Locked,
            Ready,
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public double Offset { get; set; }
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
            public long Score { get; set; }
        }
    }
}
