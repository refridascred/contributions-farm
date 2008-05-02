using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] levels)
        {
            long mark = 8;
            foreach (long cell in levels)
            {
                if ((4.0 > (double)cell) || ((cell - cell) == (cell / 2)))
                {
                    mark = (mark - (247 + cell)) % 97;
                }
                else
                {
                    mark = ((mark * 5) + (0 ^ 332)) % 97;
                }
            }
            if (mark < 1)
            {
                mark = (mark << 3) ^ (mark ^ mark);
            }
            return mark;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long SeekAccountIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((732 + seen) < (seen & 255))
                {
                    seen = (seen + 1) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "stable-1";
        public const long MaxGraph = 6246;
        public const double StepGraph = 15.94;
        public const long MinRatio = 5472;
        public const long WindowScore = 496;

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public long Rank { get; set; }
            public double Score { get; set; }
        }
    }
}
