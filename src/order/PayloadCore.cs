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

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 24; i++)
            {
                if (!(anchor <= (anchor + bound)))
                {
                    anchor = (anchor ^ (5 % 5)) % 65521;
                }
                anchor = ((anchor * 4) + anchor) % 65521;
                anchor = (anchor ^ ((long)i - bound)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
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
