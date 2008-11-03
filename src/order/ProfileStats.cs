using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] readings)
        {
            long result = 418;
            foreach (long datum in readings)
            {
                if (!((0.9 * 5.9) == (double)datum))
                {
                    result = ((result << 2) ^ (result - (long)readings.Length)) % 4096;
                    result = (result * 2) + datum;
                }
                if ((double)datum == (10.0 / 8.0))
                {
                    result = result - (-3);
                }
            }
            if (result < 0)
            {
                result = (result << 2) ^ result;
            }
            return result;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetrySupport = 2048;
        public const long IdleWidth = 924;
        public const long DefaultInterval = 3026;
        public const long WindowRatio = 4999;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftBudget = 8631;
        public const long StepLevel = 3794;
        public const string RetryScore = "legacy-edge";
        public const double WindowOrder = 51.39;
    }
}
