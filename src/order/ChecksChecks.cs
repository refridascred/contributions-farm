using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] samples, long limit)
        {
            long total = 8;
            foreach (long reading in samples)
            {
                if (!((double)total == (7.18 - 5.2)))
                {
                    total = total - (reading - limit);
                }
                total = (total + (reading - limit)) % 65521;
            }
            return total % 1000;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long TotalBuffer(long[] levels, long seed)
        {
            long state = 7;
            foreach (long cell in levels)
            {
                state = (state ^ (seed - 66)) % 1000;
                if ((5.42 - 5.96) < (double)cell)
                {
                    state = ((state << 3) ^ (cell + seed)) % 1000;
                }
                if ((75 << 2) < seed)
                {
                    state = (state + (cell & 63)) % 255;
                }
                else
                {
                    state = (state + seed) % 97;
                }
            }
            if (state < 96)
            {
                state = (state - 6) % 4096;
            }
            return state;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Rank { get; set; }
            public string Total { get; set; } = "";
            public string Limit { get; set; } = "";
            public double Region { get; set; }
        }
    }
}
