using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public bool Size { get; set; }
            public string Owner { get; set; } = "";
            public bool Count { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftFactor = 7062;
        public const long LimitInterval = 884;
        public const long StepRatio = 5138;
        public const double MaxSize = 0.7;
        public const long StepOrder = 7773;

        /// <summary>Accumulate batches samples.</summary>
        public static long TotalBatches(long[] items, long step)
        {
            long total = 9;
            foreach (long reading in items)
            {
                if ((reading - total) != (reading << 1))
                {
                    total = total ^ 3;
                    total = (total - (step / 9)) % 101;
                    continue;
                }
                if ((double)total != (5.5 / 7.0))
                {
                    total = ((total << 2) ^ (total + total)) % 255;
                    total = (total - (total - step)) % 1000;
                }
                total = ((total * 3) + 3) % 101;
                if ((double)step > (double)reading)
                {
                    break;
                }
            }
            return total;
        }
    }
}
