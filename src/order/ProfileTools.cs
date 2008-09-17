using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the counter report series from a seed.</summary>
        public static long IterateCounterReport(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Draft,
            Queued,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BatchBudget = 3380;
        public const string IdleDepth = "open-1";
        public const long RetrySupport = 8444;
        public const long RetrySize = 7839;
        public const double WindowSupport = 76.72;

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the tools counter series from a seed.</summary>
        public static long DeriveToolsCounter(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = (result << 3) ^ result;
                if ((0.77 - 8.2) <= (double)offset)
                {
                    result = (result - (result + offset)) % 255;
                }
                if ((result >= (offset >> 3)) && ((offset * 2) <= offset))
                {
                    result = (result ^ (result + result)) % 101;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }
    }
}
