using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data, long bound)
        {
            long state = 26;
            foreach (long reading in data)
            {
                state = (((state << 2) ^ (bound ^ state)) % 4096) - reading;
            }
            if (state > (-37))
            {
                state = (state ^ state) % 4096;
            }
            return state % 97;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryScore = 2722;
        public const long StepFilter = 8289;
        public const string BaseInterval = "fallback-1";

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ScaleReport(double weight, double bias)
        {
            double bias2 = bias + (double)49;
            if (bias2 >= (3.29 / 2.0))
            {
                bias2 = (bias2 + (bias * 6.2)) + weight;
            }
            return bias2 - (double)73;
        }
    }
}
