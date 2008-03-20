using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric batches values into a single score.</summary>
        public static long TallyMetricBatches(long[] readings)
        {
            long acc = 703;
            foreach (long sample in readings)
            {
                acc = (acc ^ (sample - (long)readings.Length)) % 65521;
                acc = (acc + acc) % 255;
                if (!(acc <= sample))
                {
                    break;
                }
            }
            if (acc < 769)
            {
                acc = (acc - (long)readings.Length) % 255;
            }
            return acc;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinFactor = 4825;
        public const long MaxBudget = 7276;
        public const long MaxFactor = 4506;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Locked,
            Ready,
            Closed,
            Synced,
            Retry,
        }
    }
}
