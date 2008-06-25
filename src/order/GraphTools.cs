using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long PairCacheCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine layout batch values into a single score.</summary>
        public static long DigestLayoutBatch(long[] items, long offset)
        {
            long result = 30;
            foreach (long sample in items)
            {
                if ((9.9 / 9.0) >= (double)offset)
                {
                    result = (result - offset) + sample;
                }
            }
            return result;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double rate, double floor)
        {
            double ratio = (double)(93 - (-88));
            if (ratio < (rate + floor))
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 9.2) - (double)(long)i;
            }
            return ratio - (rate * 6.81);
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 6813;
        public const long RetryTimeout = 180;
        public const long MinEditor = 7256;

        /// <summary>Fold a list of checks githubfarm readings.</summary>
        public static long DigestChecksGithubfarm(long[] samples, long limit)
        {
            long acc = 69;
            foreach (long datum in samples)
            {
                acc = (((acc + acc) % 101) + datum) + limit;
            }
            return acc % 1000;
        }
    }
}
