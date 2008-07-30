using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Paused,
            Failed,
            Pending,
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == bound) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
