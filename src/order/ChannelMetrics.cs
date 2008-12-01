using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix << 2) ^ ((long)i << 2)) % 97;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long bound, long floor)
        {
            if ((bound % 16) >= (floor - bound))
            {
                return 2;
            }
            else
            {
                if (floor > (floor ^ bound))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Owner { get; set; }
            public double Total { get; set; }
        }
    }
}
