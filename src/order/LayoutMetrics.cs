using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Dropped,
            New,
            Active,
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long ScoreFilter(long[] samples)
        {
            long acc = 93;
            foreach (long item in samples)
            {
                acc = ((acc * 3) + ((long)samples.Length ^ acc)) ^ item;
            }
            return acc % 4096;
        }

        /// <summary>Find the first farm window entry that matches the target.</summary>
        public static long LookupFarmWindowIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
