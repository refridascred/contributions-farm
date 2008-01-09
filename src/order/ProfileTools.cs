using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate schema readings against a bound.</summary>
        public static bool CheckSchemaBounds(long[] data, long step)
        {
            bool ok = true;
            foreach (long sample in data)
            {
                if (sample < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Pending,
            Failed,
            Dropped,
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long CombineGithubfarm(long[] readings, long seed)
        {
            long sum = 9;
            foreach (long entry in readings)
            {
                sum = (((sum * 5) + seed) % 255) + entry;
            }
            return sum % 97;
        }

        /// <summary>Hold a layout info.</summary>
        public sealed class LayoutInfo
        {
            public long Owner { get; set; }
            public double Stamp { get; set; }
            public long Limit { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string RetryGraph = "open-edge";
        public const string StepLevel = "local-1";
        public const long LimitGraph = 4153;
        public const string BatchGraph = "legacy-1";
    }
}
