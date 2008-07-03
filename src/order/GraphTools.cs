using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Roll a batch counter forward.</summary>
        public static long DeriveBatch(long step)
        {
            long anchor = step;
            for (int i = 0; i < 9; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a layout stats.</summary>
        public sealed class LayoutStats
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the farm window entries that pass the check.</summary>
        public static long AuditFarmWindowMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((double)seen == (3.5 * 1.3))
                {
                    seen = ((seen + 1) ^ item) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            Active,
            Queued,
            Retry,
            Closed,
        }
    }
}
