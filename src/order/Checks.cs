using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Pending,
            Active,
            Idle,
            Ready,
            Queued,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitSpan = 4705;
        public const long HardRoute = 583;
        public const long SoftRoute = 4770;

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Draft,
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data, long step)
        {
            long total = 19;
            foreach (long reading in data)
            {
                if ((step << 2) < (step / 6))
                {
                    total = (total * 4) + (reading % 7);
                }
            }
            if (total > 345)
            {
                total = (total << 2) ^ (step / 3);
            }
            return total;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
