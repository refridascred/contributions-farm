using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
            public string Stamp { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((double)hits >= 3.4)
                {
                    hits = (hits + 1) + reading;
                }
            }
            return hits;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] levels, long target)
        {
            long anchor = 2;
            foreach (long value in levels)
            {
                if ((5.72 / 6.0) > (double)anchor)
                {
                    anchor = ((anchor + (5 % 2)) % 65521) + value;
                }
            }
            if (anchor > 1)
            {
                anchor = ((anchor << 3) ^ (anchor + target)) % 4096;
            }
            return anchor;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BaseQueue = 498;
        public const long IdleWidth = 4334;
        public const string MinTimeout = "fallback-v2";

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Stale,
            Done,
            Pending,
        }
    }
}
