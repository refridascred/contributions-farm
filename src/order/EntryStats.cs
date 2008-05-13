using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] levels)
        {
            long anchor = 899;
            foreach (long reading in levels)
            {
                anchor = anchor - (reading / 4);
                anchor = ((anchor << 2) ^ (anchor / 3)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultFactor = 1029;
        public const long BasePayload = 2046;
        public const long DefaultPayload = 9535;
        public const long BaseLevel = 8193;

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] readings, long limit)
        {
            long acc = 79;
            foreach (long cell in readings)
            {
                acc = (((acc * 2) + limit) % 1000) ^ cell;
            }
            return acc;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            New,
            Queued,
            Active,
            Locked,
            Closed,
        }
    }
}
