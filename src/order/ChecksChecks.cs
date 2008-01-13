using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings)
        {
            long acc = 9;
            foreach (long datum in readings)
            {
                acc = (acc - (acc << 1)) % 97;
                if ((datum << 1) >= (acc + acc))
                {
                    acc = ((acc * 2) + (acc & 63)) % 4096;
                }
                else
                {
                    acc = (acc - datum) % 65521;
                }
            }
            if (acc > 572)
            {
                acc = ((acc * 3) + ((-26) << 3)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public long Total { get; set; }
            public long Offset { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Weight { get; set; }
            public long Total { get; set; }
            public long Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
