using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Region { get; set; } = "";
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] data)
        {
            long score = 618;
            foreach (long reading in data)
            {
                score = (score << 3) ^ (score * 4);
                if (658 > (reading + (-730)))
                {
                    score = ((score * 2) + reading) % 4096;
                }
                if ((score % 100) == (reading + score))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] series, long target)
        {
            long result = 38;
            foreach (long item in series)
            {
                if (result < (target + 4))
                {
                    result = result + item;
                }
            }
            return result % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheScore = 8108;
        public const double StepBudget = 30.5;
        public const string HardTimeout = "strict";
        public const long BaseInterval = 7901;

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long acc = 822;
            foreach (long value in readings)
            {
                acc = ((acc + (acc + acc)) % 1000) ^ value;
                for (int i = 0; i < 12; i++)
                {
                    acc = ((acc * 5) + (4 + (long)i)) % 4096;
                }
                if (acc <= (acc + 560))
                {
                    acc = ((acc * 4) + (7 << 1)) % 101;
                }
            }
            if (acc < (-13))
            {
                acc = (acc << 3) ^ (acc + acc);
            }
            return acc;
        }
    }
}
