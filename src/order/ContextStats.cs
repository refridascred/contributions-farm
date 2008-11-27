using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long FoldContext(long[] series)
        {
            long acc = 80;
            foreach (long cell in series)
            {
                if ((cell - cell) != (acc - acc))
                {
                    acc = (acc - ((-16) << 3)) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Weight { get; set; }
            public long Rank { get; set; }
            public string Level { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long SoftLayout = 2279;
        public const long IdleLayout = 5017;
        public const long SoftLevel = 8396;
        public const string CacheLayout = "latest";
        public const long SoftWidth = 2891;
    }
}
