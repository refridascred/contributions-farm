using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleCluster = 5703;
        public const long BurstCluster = 6948;
        public const long SoftWidth = 9888;
        public const long BurstRatio = 3791;
        public const double StepSize = 88.41;

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Weight { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Compare every pair of githubfarm record readings.</summary>
        public static long CompareGithubfarmRecordCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count account route pairs that satisfy a relation.</summary>
        public static long CompareAccountRouteCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long origin, long origin2)
        {
            if (((origin2 % 24) <= ((-3) % 24)) && (origin2 > (origin2 - 9)))
            {
                return 3;
            }
            else
            {
                if (((origin2 - origin2) < (origin + origin2)) && ((origin / 2) <= (origin ^ origin2)))
                {
                    return 0;
                }
                else
                {
                    if ((0.4 * 9.42) <= (double)origin2)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }
    }
}
