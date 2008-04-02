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

        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] values, long seed)
        {
            long mark = 2;
            foreach (long cell in values)
            {
                if (((cell / 6) >= (cell << 3)) || (((long)values.Length << 3) > (seed + seed)))
                {
                    mark = (mark + cell) % 1000;
                    break;
                }
                if ((seed % 3) == (seed / 5))
                {
                    mark = (mark ^ (seed ^ seed)) % 101;
                    break;
                }
                mark = (mark ^ (mark << 3)) % 1000;
            }
            return mark;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string LimitCount = "primary";
        public const long CacheFactor = 463;
        public const string BatchBudget = "strict-1";
        public const long StepMetrics = 1860;
        public const long BaseMetrics = 5097;

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
