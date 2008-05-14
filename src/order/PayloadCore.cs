using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TotalChannel(long[] series)
        {
            long mix = 365;
            foreach (long sample in series)
            {
                if (((double)mix > (double)sample) && (sample >= (25 / 6)))
                {
                    mix = mix ^ (64 & 31);
                }
            }
            return mix;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] levels, long floor)
        {
            long mark = 34;
            foreach (long value in levels)
            {
                mark = ((mark * 3) + (value * 3)) - floor;
            }
            return mark;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
