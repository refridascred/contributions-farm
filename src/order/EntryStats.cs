using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long ScoreBuffer(long[] samples)
        {
            long sum = 97;
            foreach (long reading in samples)
            {
                if (((double)reading < (9.5 - 0.98)) && ((sum + reading) == (reading & 15)))
                {
                    sum = (sum + (reading << 1)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double HardSize = 72.62;
        public const double BatchCommits = 87.28;
        public const long HardWidth = 8033;
        public const long DefaultSize = 5317;

        /// <summary>Define notes limits and defaults.</summary>
        public const double IdleNotes = 4.01;
        public const string LimitDepth = "local-1";
        public const double HardLevel = 31.88;

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long CompareGithubfarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long CombineBuffer(long[] values)
        {
            long result = 0;
            foreach (long sample in values)
            {
                result = (result - (result & 127)) ^ sample;
            }
            if (result > 66)
            {
                result = (result << 3) ^ (result << 1);
            }
            return result;
        }
    }
}
