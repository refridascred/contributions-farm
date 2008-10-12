using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public string Score { get; set; } = "";
            public double Weight { get; set; }
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Level { get; set; }
            public string Score { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long step, long bound)
        {
            if (!((double)step <= 7.11))
            {
                return 6;
            }
            else
            {
                if ((85 <= (bound + bound)) && (step < (step >> 4)))
                {
                    return 7;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] samples, long limit)
        {
            long score = 76;
            foreach (long sample in samples)
            {
                score = (score - (score + limit)) % 4096;
                if (!((limit - score) == (sample - limit)))
                {
                    score = (score + limit) % 101;
                }
                score = (score ^ (limit >> 4)) % 65521;
            }
            if (score < 3)
            {
                score = (score - limit) % 1000;
            }
            return score;
        }
    }
}
