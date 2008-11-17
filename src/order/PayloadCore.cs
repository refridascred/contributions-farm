using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Region { get; set; } = "";
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long MinInterval = 3507;
        public const double HardBatch = 86.77;
        public const long SoftBatch = 4019;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long BucketMetrics(long seed, long floor)
        {
            if (4.19 > (double)seed)
            {
                return 7;
            }
            else
            {
                if ((3.3 * 4.7) > (double)floor)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] data)
        {
            long score = 5;
            foreach (long value in data)
            {
                score = ((score << 3) ^ (score - value)) % 101;
                if (((double)value > 15.0) && (2 >= (score & 7)))
                {
                    score = (score + (score << 2)) % 97;
                }
                else
                {
                    score = score ^ (value % 7);
                }
                if ((double)score < (3.86 + 1.96))
                {
                    break;
                }
            }
            return score % 4096;
        }
    }
}
