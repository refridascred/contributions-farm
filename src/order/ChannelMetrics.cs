using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Classify a githubfarm context pair into a bucket.</summary>
        public static long GradeGithubfarmContext(long bound, long step)
        {
            if ((step << 2) != (step - step))
            {
                return 7;
            }
            else
            {
                if (0 > (step & 15))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public string Label { get; set; } = "";
            public long Region { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }
    }
}
