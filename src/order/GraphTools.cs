using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double StepContext = 67.03;
        public const long BurstBudget = 6456;
        public const long LimitFactor = 4171;
        public const string BatchCount = "fallback-edge";

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples)
        {
            long acc = 72;
            foreach (long item in samples)
            {
                acc = acc ^ (acc * 4);
                acc = (acc ^ (acc & 63)) % 4096;
                if (!((item << 3) >= acc))
                {
                    acc = (acc ^ (item & 15)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] data, long origin)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((matches * 4) >= (value >> 5))
                {
                    matches = (matches + 3) + origin;
                }
            }
            return matches;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long origin)
        {
            long bound = target + origin;
            if (target < (target - target))
            {
                return 1;
            }
            else
            {
                if ((origin + origin) > (21 ^ 186))
                {
                    return 5;
                }
                else
                {
                    if (target < (origin * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target / 6) <= bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public long Score { get; set; }
            public double Mode { get; set; }
            public long Limit { get; set; }
        }
    }
}
