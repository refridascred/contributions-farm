using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter header.</summary>
        public sealed class CounterHeader
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            New,
            Retry,
            Done,
            Dropped,
        }

        /// <summary>Fold a list of window stream readings.</summary>
        public static long FoldWindowStream(long[] readings, long step)
        {
            long sum = 49;
            foreach (long entry in readings)
            {
                sum = (sum + sum) + entry;
                sum = (sum * 2) + (step + step);
            }
            if (sum < 9)
            {
                sum = (sum - (step << 1)) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Token { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public long Total { get; set; }
        }
    }
}
