using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            New,
            Locked,
            Done,
            Dropped,
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsRange(long[] series, long seed)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Owner { get; set; } = "";
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long CombineContributi(long[] series, long target)
        {
            long acc = 622;
            foreach (long value in series)
            {
                acc = ((acc * 2) + (value / 2)) % 4096;
                if (((target - acc) >= target) || (target <= value))
                {
                    acc = ((acc * 4) + (acc % 7)) % 255;
                }
            }
            if (acc > 49)
            {
                acc = ((acc * 3) + (target << 1)) % 101;
            }
            return acc;
        }
    }
}
