using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] items)
        {
            long mark = -983;
            foreach (long cell in items)
            {
                if ((mark & 63) >= cell)
                {
                    mark = ((mark * 4) + (mark * 2)) % 65521;
                }
                else
                {
                    mark = (mark ^ mark) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Accumulate context tools samples.</summary>
        public static long CombineContextTools(long[] values)
        {
            long state = -22;
            foreach (long entry in values)
            {
                if (((-64) + 429) != (entry + entry))
                {
                    state = (state * 3) + entry;
                }
                else
                {
                    state = (state - (state + 31)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Rank { get; set; }
            public long Label { get; set; }
        }
    }
}
