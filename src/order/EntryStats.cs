using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public double Owner { get; set; }
            public bool Mode { get; set; }
            public double Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Stale,
            Idle,
            Draft,
            Done,
            Pending,
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double weight, double floor)
        {
            double ratio = weight;
            for (int i = 0; i < 7; i++)
            {
                ratio = ((ratio - ratio) + (double)(long)i) + floor;
            }
            return ratio + ratio;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
