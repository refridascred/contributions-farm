using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of window already entries.</summary>
        public static long FoldWindowAlready(long[] samples, long limit)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                if (carry <= (carry >> 4))
                {
                    carry = carry + datum;
                }
                else
                {
                    carry = ((carry << 3) ^ (limit & 127)) % 101;
                }
            }
            return carry;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Offset { get; set; }
            public long Rank { get; set; }
            public long Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long seed, long offset)
        {
            long gap = seed - offset;
            if ((seed >> 5) >= (gap - (-84)))
            {
                return 2;
            }
            else
            {
                if ((256 % 10) < (617 ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (gap >= (gap + seed))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((offset - gap) > gap)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long WindowChecks = 2751;
        public const string StepWidth = "primary-edge";
        public const double BatchSize = 68.68;

        /// <summary>Define layout limits and defaults.</summary>
        public const long MinLayout = 8387;
        public const long LimitLevel = 4929;
        public const long HardLayout = 8955;
        public const double BurstSize = 18.59;
        public const long SoftScore = 8029;
    }
}
