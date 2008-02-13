using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitLevel = 9588;
        public const long RetryNotes = 7689;
        public const long SoftNotes = 7524;
        public const long DefaultSpan = 3738;
        public const string IdleLevel = "legacy-1";

        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] data, long offset)
        {
            long mark = 990;
            foreach (long value in data)
            {
                mark = (mark ^ (offset / 5)) % 97;
                if (!(offset <= ((long)data.Length - mark)))
                {
                    break;
                }
                if (!((18.0 * 6.6) > (double)offset))
                {
                    mark = (mark + (mark + value)) % 1000;
                }
            }
            return mark % 1000;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Stamp { get; set; }
            public double Mode { get; set; }
        }
    }
}
