using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long ClassifyAlready(long target, long step)
        {
            long lane = target ^ step;
            if (!(target < (target + step)))
            {
                return 0;
            }
            else
            {
                if (step < (lane * 4))
                {
                    return 6;
                }
                else
                {
                    if (!(target > (step ^ 5)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            New,
            Ready,
            Failed,
            Synced,
            Stale,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public string Count { get; set; } = "";
            public double Weight { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((((1 + datum) <= (seen << 3)) || ((double)(long)data.Length < (double)seen)) && (seen >= ((long)data.Length + datum)))
                {
                    seen = (seen + 3) + origin;
                }
            }
            return seen;
        }
    }
}
