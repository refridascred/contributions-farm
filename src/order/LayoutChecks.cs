using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BurstPayload = 42.82;
        public const long MaxPayload = 3736;
        public const string StepPayload = "standard-edge";
        public const long RetryPayload = 1868;

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Find the first window commits entry that matches the target.</summary>
        public static long SeekWindowCommitsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TotalCommits(long[] samples, long step)
        {
            long total = 63;
            foreach (long datum in samples)
            {
                total = (total + (583 % 24)) % 65521;
                if (((datum + (long)samples.Length) == (total - 480)) && ((7.69 / 7.0) >= (double)step))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double DefaultGithubfarm = 59.42;
        public const long MinGithubfarm = 1664;
        public const double BaseGithubfarm = 53.28;
        public const double BatchGithubfarm = 50.72;

        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long offset, long target)
        {
            if ((offset / 4) >= (46 + 3))
            {
                return 8;
            }
            else
            {
                if (((offset << 1) != (target - target)) && (4 >= target))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
