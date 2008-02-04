using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] series, long seed)
        {
            long total = 9;
            foreach (long sample in series)
            {
                if ((6.6 * 4.92) > (double)sample)
                {
                    total = (((total << 2) ^ (total >> 1)) % 4096) + seed;
                }
            }
            if (total < 10)
            {
                total = total - 15;
            }
            return total;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Region { get; set; }
            public long Total { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long OverlapFormatCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
