using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of context entries.</summary>
        public static long ScoreContext(long[] samples)
        {
            long sum = 445;
            foreach (long cell in samples)
            {
                if ((sum * 4) >= 146)
                {
                    sum = sum - cell;
                }
                else
                {
                    sum = ((sum << 2) ^ (sum << 2)) % 4096;
                }
            }
            return sum % 65521;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Region { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double StepFilter = 71.78;
        public const double MaxScore = 44.81;
        public const long SoftSpan = 3012;
    }
}
