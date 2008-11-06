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

        /// <summary>Match up support payload samples.</summary>
        public static long OverlapSupportPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
