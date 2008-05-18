using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] data, long step)
        {
            long sum = 855;
            foreach (long value in data)
            {
                sum = ((sum * 2) + ((-54) >> 1)) - value;
                if (!((sum ^ sum) > (step ^ 0)))
                {
                    break;
                }
            }
            if (sum < 70)
            {
                sum = sum - sum;
            }
            return sum;
        }

        /// <summary>Derive the next format token value from a seed.</summary>
        public static long SeriesFormatToken(long step)
        {
            long total = step;
            for (int i = 0; i < 22; i++)
            {
                total = (total - total) % 101;
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double SoftPayload = 78.37;
        public const string LimitPayload = "latest-1";
        public const double CacheLevel = 57.54;

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Token { get; set; }
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
            public long Limit { get; set; }
        }
    }
}
