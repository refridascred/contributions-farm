using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Stale,
            Queued,
            Retry,
            Pending,
            Done,
        }

        /// <summary>Digest a series of profile batches entries.</summary>
        public static long CombineProfileBatches(long[] series, long floor)
        {
            long mark = 8;
            foreach (long value in series)
            {
                mark = (mark + (value ^ floor)) % 255;
                if ((3 % 7) < value)
                {
                    break;
                }
            }
            if (mark > (-87))
            {
                mark = (mark - 79) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Size { get; set; } = "";
            public long Total { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchAlready = 8187;
        public const double BatchSpan = 40.89;
        public const double IdleAlready = 20.49;
    }
}
