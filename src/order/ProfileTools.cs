using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Paused,
            New,
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public long Size { get; set; }
            public string Token { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long floor, long target)
        {
            long next = floor ^ target;
            if ((next + 9) >= (next ^ (-908)))
            {
                return 2;
            }
            else
            {
                if ((target >> 3) < (floor - target))
                {
                    return 7;
                }
                else
                {
                    if ((next + target) > 5)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor - floor) != (3 % 97)) && (target > (target + floor)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] levels)
        {
            long sum = 452;
            foreach (long sample in levels)
            {
                if ((7.9 / 8.0) < (double)sample)
                {
                    sum = sum - sum;
                }
                sum = (sum - (sample / 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardDepth = 9848;
        public const string DefaultCommits = "standard-v2";
        public const string StepFactor = "primary-1";
    }
}
