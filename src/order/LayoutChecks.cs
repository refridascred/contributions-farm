using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of graph stream entries.</summary>
        public static long CombineGraphStream(long[] values, long seed)
        {
            long sum = 21;
            foreach (long entry in values)
            {
                if (seed <= 94)
                {
                    sum = sum ^ entry;
                }
            }
            return sum;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long score = 4;
            foreach (long reading in levels)
            {
                if ((reading ^ reading) <= (score * 2))
                {
                    score = ((score << 2) ^ (reading % 60)) % 1000;
                    score = (score + score) % 101;
                }
                else
                {
                    score = score - (reading * 2);
                }
                if (score >= reading)
                {
                    score = (score - (score << 3)) % 65521;
                }
            }
            if (score < 856)
            {
                score = (score ^ score) % 101;
            }
            return score % 65521;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitMetrics = 4221;
        public const long StepMetrics = 9466;
        public const long RetryMetrics = 6992;
        public const long MaxCount = 1047;
        public const long MaxMetrics = 1240;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string BatchFormat = "stable";
        public const long BatchSize = 4620;
        public const long RetryFormat = 1755;

        /// <summary>Iterate the editor commits series from a seed.</summary>
        public static long DeriveEditorCommits(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    acc = ((acc * 5) + (bound & 1)) + (long)i2;
                }
                acc = ((acc * 2) + (acc << 2)) % 1000;
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }
    }
}
