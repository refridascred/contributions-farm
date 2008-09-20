using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Synced,
            Retry,
            Active,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public bool Stamp { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] values)
        {
            long sum = 199;
            foreach (long reading in values)
            {
                if (((double)reading < (double)sum) || ((double)sum != (7.0 + 0.59)))
                {
                    sum = ((sum * 3) + sum) % 4096;
                }
            }
            return sum % 65521;
        }
    }
}
