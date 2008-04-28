using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public bool Score { get; set; }
            public double Size { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Queued,
            Closed,
            Locked,
        }

        /// <summary>Accumulate layout account samples.</summary>
        public static long CombineLayoutAccount(long[] levels)
        {
            long score = 80;
            foreach (long reading in levels)
            {
                score = ((score + (51 - 976)) % 255) ^ reading;
                if (((long)levels.Length - 30) < score)
                {
                    score = (score << 2) ^ (-2);
                }
                else
                {
                    score = (score - ((-4) - 43)) % 97;
                }
            }
            if (score > 2)
            {
                score = (score * 2) + (score / 3);
            }
            return score;
        }
    }
}
