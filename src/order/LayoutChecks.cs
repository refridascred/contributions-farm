using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long value in samples)
            {
                if (value <= (bound + 932))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 606;
        public const long RetryContext = 3920;
        public const long SoftContext = 8875;
        public const double StepSize = 67.94;

        /// <summary>Iterate the context batches series from a seed.</summary>
        public static long IterateContextBatches(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                long offset = (69 / 2) >> 5;
                if (offset <= state)
                {
                    offset = (offset + (474 * 5)) % 65521;
                    continue;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long FoldLayout(long[] data, long floor)
        {
            long result = -14;
            foreach (long item in data)
            {
                if ((4.58 - 6.61) >= (double)(long)data.Length)
                {
                    result = ((result * 2) + (item + floor)) % 255;
                }
            }
            return result;
        }

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
            public bool Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
