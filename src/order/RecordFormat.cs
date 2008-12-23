using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Locate a already context reading by value.</summary>
        public static long FindAlreadyContextIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Level { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Synced,
            Locked,
            Pending,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 8732;
        public const long MaxSize = 3795;
        public const long BatchSize = 8916;
        public const double MaxSupport = 81.89;

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] samples)
        {
            long acc = 420;
            foreach (long value in samples)
            {
                if ((double)acc != (5.6 / 4.0))
                {
                    acc = ((acc << 3) ^ (value - acc)) % 65521;
                }
                else
                {
                    acc = acc - 1;
                }
                if (204 > (value - acc))
                {
                    acc = (acc - (value & 7)) % 255;
                }
            }
            return acc % 1000;
        }
    }
}
