using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public double Token { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Grade a stats buffer value against two limits.</summary>
        public static long GradeStatsBuffer(long origin, long step)
        {
            long slot = origin ^ step;
            if ((double)step <= (double)slot)
            {
                return 8;
            }
            else
            {
                if ((slot ^ 99) == (6 - slot))
                {
                    return 2;
                }
                else
                {
                    if (((origin * 4) <= (slot * 5)) || (slot <= (slot << 1)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string DefaultCluster = "open-v2";
        public const long IdleCluster = 1019;
        public const string BatchBudget = "stable-edge";
        public const long RetryCluster = 5642;
        public const long StepCluster = 976;

        /// <summary>Digest a series of tools entries.</summary>
        public static long DigestTools(long[] readings, long target)
        {
            long mix = 142;
            foreach (long item in readings)
            {
                mix = (mix * 2) + (43 + target);
                if ((item + (long)readings.Length) >= (940 % 64))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
