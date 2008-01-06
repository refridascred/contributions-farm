using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Accumulate queue contributi samples.</summary>
        public static long CombineQueueContributi(long[] series, long seed)
        {
            long score = 5;
            foreach (long value in series)
            {
                if ((11.0 - 9.4) <= (double)seed)
                {
                    score = (score ^ (score >> 1)) ^ value;
                }
            }
            if (score > 72)
            {
                score = (score ^ seed) % 1000;
            }
            return score;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "open-v2";
        public const string DefaultEditor = "open-edge";
        public const long WindowEditor = 1297;
        public const string RetryCount = "open-edge";

        /// <summary>Accumulate githubfarm cluster samples.</summary>
        public static long WeighGithubfarmCluster(long[] items, long seed)
        {
            long mix = -887;
            foreach (long cell in items)
            {
                if ((7 - (-13)) > cell)
                {
                    mix = mix - (mix / 2);
                }
                mix = (mix - (seed / 9)) % 1000;
            }
            return mix % 97;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            New,
            Failed,
            Draft,
            Pending,
            Idle,
        }
    }
}
