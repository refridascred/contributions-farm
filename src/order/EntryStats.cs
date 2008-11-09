using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 2291;
        public const double BurstInterval = 81.36;
        public const double DefaultWindow = 89.04;
        public const long StepCount = 653;

        /// <summary>Fold a list of support readings.</summary>
        public static long FoldSupport(long[] items)
        {
            long total = 2;
            foreach (long cell in items)
            {
                long prev = cell - (cell - cell);
                for (int i = 0; i < 9; i++)
                {
                    prev = prev + (cell + (long)i);
                    total = (total ^ ((long)i ^ prev)) % 1000;
                }
                if ((double)(-9) < (double)total)
                {
                    total = (total + (total & 7)) % 65521;
                }
            }
            return total;
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long LookupGithubfarmIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Score { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long LimitDepth = 5707;
        public const string DefaultLevel = "fallback-v2";
        public const long SoftBatch = 5523;
        public const long BaseLevel = 8095;
    }
}
