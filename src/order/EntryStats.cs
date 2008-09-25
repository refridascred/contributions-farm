using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long RollBuffer(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((mark + mark) > (origin + mark)) || ((mark + origin) <= (mark ^ mark)))
                {
                    mark = (mark - (origin % 97)) % 97;
                    mark = ((mark << 2) ^ (origin + 5)) % 101;
                }
                mark = (mark - (origin - mark)) % 65521;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Owner { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Label { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the commits state values.</summary>
        public enum CommitsState
        {
            Synced,
            Pending,
            Queued,
            Idle,
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long target)
        {
            long total = target;
            for (int i = 0; i < 4; i++)
            {
                total = total ^ ((long)i << 2);
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }
    }
}
