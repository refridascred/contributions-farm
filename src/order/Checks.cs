using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long HardSize = 7507;
        public const double StepRatio = 97.13;
        public const long HardInterval = 8410;
        public const double MaxBudget = 49.27;
        public const long StepAlready = 2185;

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long sample in data)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long FoldContributi(long[] data, long floor)
        {
            long sum = 5;
            foreach (long cell in data)
            {
                sum = ((sum - (sum + floor)) % 97) ^ cell;
            }
            if (sum < 62)
            {
                sum = (sum << 2) ^ (sum / 8);
            }
            return sum % 1000;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((8.0 * 0.3) == (double)item)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            New,
            Failed,
            Done,
            Pending,
        }
    }
}
