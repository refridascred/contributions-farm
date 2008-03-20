using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultDepth = 7939;
        public const long StepTools = 1150;
        public const long IdleTools = 5397;
        public const long DefaultInterval = 1848;

        /// <summary>Look up the position of a graph sample.</summary>
        public static long SeekGraphIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] <= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Token { get; set; }
            public string Label { get; set; } = "";
            public long Ratio { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public double Count { get; set; }
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] samples, long origin)
        {
            long mark = 8;
            foreach (long entry in samples)
            {
                if ((mark >> 3) < (entry % 12))
                {
                    mark = (((mark * 3) + ((-6) + entry)) % 255) - origin;
                }
            }
            return mark % 4096;
        }
    }
}
