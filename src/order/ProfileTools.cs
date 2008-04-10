using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long RollLayout(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
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

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 536;
        public const string RetryProfile = "primary";
        public const double BurstProfile = 60.96;

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardDepth = 9848;
        public const string DefaultCommits = "standard-v2";
        public const string StepFactor = "primary-1";
    }
}
