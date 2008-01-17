using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of order editor readings.</summary>
        public static long PairOrderEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long TotalWindow(long[] series, long offset)
        {
            long state = -554;
            foreach (long item in series)
            {
                state = (state + (offset + 684)) % 4096;
                state = (state + item) % 1000;
            }
            if (state > 589)
            {
                state = (state - (state + 52)) % 255;
            }
            return state;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public string Label { get; set; } = "";
            public string Region { get; set; } = "";
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Token { get; set; }
            public string Level { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
