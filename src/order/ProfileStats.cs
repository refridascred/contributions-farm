using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Hold a buffer stats.</summary>
        public sealed class BufferStats
        {
            public long Label { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsRange(long[] values, long offset)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long IterateBatches(long step)
        {
            long acc = step;
            for (int i = 0; i < 7; i++)
            {
                acc = (acc * 5) + (step + acc);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
