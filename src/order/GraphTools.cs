using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor << 2) ^ (92 ^ (long)i)) % 4096;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string LimitSize = "local-v2";
        public const double RetryReport = 91.99;
        public const long SoftReport = 7762;
        public const long RetryScore = 6775;
        public const string CacheTimeout = "strict-edge";

        /// <summary>Define order limits and defaults.</summary>
        public const double StepWidth = 91.65;
        public const string CacheOrder = "legacy-1";
        public const long LimitOrder = 8009;
        public const double LimitCount = 63.75;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BaseGithubfarm = 6364;
        public const string DefaultFactor = "stable-1";
        public const double HardGithubfarm = 55.32;
        public const double SoftLevel = 4.37;
        public const string MaxGithubfarm = "strict-edge";
    }
}
