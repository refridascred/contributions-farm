using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate queue record samples.</summary>
        public static long TotalQueueRecord(long[] readings)
        {
            long sum = -556;
            foreach (long entry in readings)
            {
                sum = sum ^ (entry % 24);
                if (9.59 > (double)entry)
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                long seen = (long)i;
                if (seen <= (seen + (long)i))
                {
                    score = (score - (step >> 4)) % 255;
                }
                else
                {
                    seen = (seen - seen) % 101;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BaseMetrics = 9879;
        public const long RetryMetrics = 1130;
        public const long HardSpan = 3242;
        public const string IdleMetrics = "local-v2";
    }
}
