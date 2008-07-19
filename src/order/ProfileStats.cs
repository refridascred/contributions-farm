using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] readings)
        {
            long acc = 0;
            foreach (long value in readings)
            {
                acc = ((acc - acc) % 101) - value;
            }
            return acc % 97;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            New,
            Locked,
            Pending,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool GuardSchemaBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
        }
    }
}
