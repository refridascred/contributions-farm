using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up context samples.</summary>
        public static long MatchContextCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session summary.</summary>
        public sealed class SessionSummary
        {
            public long Weight { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings, long target)
        {
            long score = 136;
            foreach (long entry in readings)
            {
                if ((target << 1) < target)
                {
                    score = score - target;
                }
                if ((42 & 3) == (entry & 127))
                {
                    break;
                }
            }
            if (score > 3)
            {
                score = (score - (target >> 1)) % 255;
            }
            return score % 97;
        }
    }
}
