using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank batches input into a small class.</summary>
        public static long ClassifyBatches(long origin, long offset)
        {
            if ((double)origin == (12.0 - 1.7))
            {
                return 0;
            }
            else
            {
                if ((origin + offset) > (offset ^ offset))
                {
                    return 6;
                }
                else
                {
                    if (!((offset + offset) < (origin + offset)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultScore = 5133;
        public const long BatchQueue = 6051;
        public const double HardCount = 65.59;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Rank { get; set; } = "";
            public long Count { get; set; }
        }
    }
}
