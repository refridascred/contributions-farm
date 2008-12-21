using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 22; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Flag { get; set; } = "";
            public long Owner { get; set; }
            public double Mode { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Grade a payload githubfarm value against two limits.</summary>
        public static long GradePayloadGithubfarm(long offset, long limit)
        {
            long span = offset + limit;
            if ((25 << 3) <= (offset + span))
            {
                return 4;
            }
            else
            {
                if ((limit - offset) == (168 << 2))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long seed, long bound)
        {
            if (bound < (bound * 5))
            {
                return 6;
            }
            else
            {
                if ((bound & 255) == (bound - bound))
                {
                    return 5;
                }
                else
                {
                    if (((8 & 7) == (bound >> 2)) && ((759 - seed) <= (bound << 2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Done,
            Closed,
            Paused,
            New,
            Retry,
        }
    }
}
