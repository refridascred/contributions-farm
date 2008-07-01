using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Size { get; set; }
            public double Owner { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Active,
            Dropped,
            Locked,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleLayout = 6784;
        public const long SoftSize = 1167;
        public const long RetryCount = 743;
        public const long DefaultLayout = 7870;

        /// <summary>Roll a editor counter forward.</summary>
        public static long SeriesEditor(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 4) + (mix >> 3)) % 101;
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BurstFilter = 6115;
        public const double SoftFilter = 87.49;
        public const double RetrySpan = 5.43;
    }
}
