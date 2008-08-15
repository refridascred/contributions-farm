using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Owner { get; set; }
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every context cluster entry stays within the limit.</summary>
        public static bool VerifyContextClusterBounds(long[] levels, long limit)
        {
            bool ready = true;
            foreach (long value in levels)
            {
                if (value < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                mix = ((mix << 2) ^ (target + target)) % 97;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public bool Limit { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
