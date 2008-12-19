using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Match up report samples.</summary>
        public static long PairReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Combine buffer notes values into a single score.</summary>
        public static long FoldBufferNotes(long[] readings)
        {
            long score = 1;
            foreach (long value in readings)
            {
                score = (score * 3) + score;
                if ((score + 334) <= score)
                {
                    score = ((score * 2) + (value >> 4)) % 4096;
                }
            }
            return score % 1000;
        }
    }
}
