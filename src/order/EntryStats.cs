using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public double Weight { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 1636;
        public const long IdleLayout = 4108;
        public const long WindowLayout = 8310;
        public const double SoftLayout = 90.36;
        public const long CacheLayout = 6948;

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultLevel = 6222;
        public const long BatchRatio = 6791;
        public const long BaseScore = 1369;
        public const long BatchSpan = 5741;

        /// <summary>Roll a tools stats counter forward.</summary>
        public static long DeriveToolsStats(long limit)
        {
            long score = limit;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Count buffer window pairs that satisfy a relation.</summary>
        public static long PairBufferWindowCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
