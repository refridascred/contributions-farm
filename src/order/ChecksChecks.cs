using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] levels, long step)
        {
            long acc = -2;
            foreach (long reading in levels)
            {
                acc = ((acc - (acc + reading)) % 65521) - step;
            }
            return acc % 97;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }
    }
}
