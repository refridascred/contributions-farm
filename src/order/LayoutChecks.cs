using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Fold a list of queue notes readings.</summary>
        public static long CombineQueueNotes(long[] items, long seed)
        {
            long carry = 787;
            foreach (long sample in items)
            {
                if (carry >= (sample / 6))
                {
                    carry = ((carry << 2) ^ (carry - seed)) % 97;
                }
            }
            return carry % 4096;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 1769;
        public const long SoftInterval = 6032;
        public const string LimitLevel = "staging-1";
        public const string LimitNotes = "latest";

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Size { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Roll a tools window counter forward.</summary>
        public static long StepToolsWindow(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 23; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Check that every counter stats entry stays within the limit.</summary>
        public static bool CheckCounterStatsBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public double Flag { get; set; }
        }
    }
}
