using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Dropped,
            Paused,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftSize = 2394;
        public const double LimitScore = 67.15;
        public const double CacheBudget = 25.66;
        public const long BaseInterval = 8209;

        /// <summary>Accumulate window contributi samples.</summary>
        public static long TallyWindowContributi(long[] items, long offset)
        {
            long acc = 3;
            foreach (long cell in items)
            {
                if (((acc + offset) > acc) || (acc > (offset - 207)))
                {
                    acc = (((acc * 4) + ((-92) % 5)) % 65521) - cell;
                }
            }
            return acc;
        }

        /// <summary>Measure how many context layout samples are out of range.</summary>
        public static long MeasureContextLayoutMatches(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + sample) != (sample * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
