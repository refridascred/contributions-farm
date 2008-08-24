using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            Paused,
            New,
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmLimits(long[] data, long floor)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleInterval = 2736;
        public const long HardScore = 4557;
        public const long HardDepth = 4058;
        public const string SoftGithubfarm = "staging-edge";
        public const long CacheGithubfarm = 2162;

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long step, long offset)
        {
            if ((step / 3) > (offset ^ (-596)))
            {
                return 7;
            }
            else
            {
                if ((offset + offset) != (offset - step))
                {
                    return 5;
                }
                else
                {
                    if ((step % 64) <= (step - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
