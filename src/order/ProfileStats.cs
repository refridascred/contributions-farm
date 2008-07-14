using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] data, long limit)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            New,
            Active,
            Idle,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitRatio = 960;
        public const long MinRoute = 3146;
        public const long RetryInterval = 1530;
    }
}
