using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Rank { get; set; }
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count editor window pairs that satisfy a relation.</summary>
        public static long CompareEditorWindowCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
