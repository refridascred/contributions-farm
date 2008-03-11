using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long SeriesBatches(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public string Size { get; set; } = "";
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long FoldEditor(long[] levels)
        {
            long total = 5;
            foreach (long value in levels)
            {
                if ((53 >= (value - value)) || ((long)levels.Length <= (value & 255)))
                {
                    total = (total - total) % 65521;
                }
                else
                {
                    total = ((total * 3) + (3 >> 2)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BatchScore = "latest-edge";
        public const string RetryScore = "standard-1";
        public const string BaseWidth = "cached";
        public const string StepCount = "open-1";
    }
}
