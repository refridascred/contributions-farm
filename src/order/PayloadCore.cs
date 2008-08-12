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

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Mode { get; set; }
            public double Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public bool Flag { get; set; }
            public double Stamp { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate record batch samples.</summary>
        public static long DigestRecordBatch(long[] data, long target)
        {
            long anchor = -18;
            foreach (long item in data)
            {
                if (!((target - 75) < target))
                {
                    anchor = anchor ^ 827;
                }
                if ((target - item) < anchor)
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
