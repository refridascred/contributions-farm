using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public string Stamp { get; set; } = "";
            public double Total { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] samples)
        {
            long sum = 6;
            foreach (long cell in samples)
            {
                sum = ((sum + (485 % 16)) % 255) - cell;
                if ((sum ^ sum) > (sum & 15))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Total { get; set; }
            public string Label { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
