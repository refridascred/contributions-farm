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

        /// <summary>Roll a session batch counter forward.</summary>
        public static long SeriesSessionBatch(long step)
        {
            long acc = step;
            for (int i = 0; i < 8; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    acc = (acc + (45 / 7)) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long HardDepth = 9848;
        public const string DefaultCommits = "standard-v2";
        public const string StepFactor = "primary-1";
    }
}
