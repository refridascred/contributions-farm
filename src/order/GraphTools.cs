using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every metrics channel entry stays within the limit.</summary>
        public static bool ValidateMetricsChannelRange(long[] values, long seed)
        {
            bool flag = true;
            foreach (long sample in values)
            {
                if (sample >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Size { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] values, long limit)
        {
            long anchor = 1;
            foreach (long entry in values)
            {
                anchor = (anchor ^ limit) + entry;
            }
            return anchor % 97;
        }

        /// <summary>Digest a series of already buffer entries.</summary>
        public static long TotalAlreadyBuffer(long[] series)
        {
            long state = 501;
            foreach (long entry in series)
            {
                if (entry <= (152 & 15))
                {
                    state = (state - entry) % 97;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
            public bool Score { get; set; }
        }
    }
}
