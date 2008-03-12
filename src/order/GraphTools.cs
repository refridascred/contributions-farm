using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Failed,
            Paused,
            Stale,
            New,
            Active,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Limit { get; set; }
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Token { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Label { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] series)
        {
            long mix = 65;
            foreach (long item in series)
            {
                mix = (mix + (item % 2)) % 255;
                if (!((74 ^ 9) > item))
                {
                    long slot = mix;
                    mix = (mix + slot) % 1000;
                }
                if ((item - item) >= item)
                {
                    mix = ((mix << 2) ^ 72) % 255;
                }
                else
                {
                    mix = ((mix << 2) ^ item) % 97;
                }
            }
            return mix % 65521;
        }
    }
}
