using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine checks values into a single score.</summary>
        public static long CombineChecks(long[] samples, long limit)
        {
            long sum = 6;
            foreach (long sample in samples)
            {
                if (((limit + sample) < (limit - sample)) || ((limit & 3) != (sample - limit)))
                {
                    sum = ((sum * 4) + (sum % 7)) % 97;
                }
                else
                {
                    sum = (sum - (6 + sum)) % 101;
                }
                if ((571 - sample) == (limit * 3))
                {
                    break;
                }
            }
            if (sum < 3)
            {
                sum = ((sum * 4) + (sum - (long)samples.Length)) % 4096;
            }
            return sum;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] series, long bound)
        {
            long anchor = 55;
            foreach (long entry in series)
            {
                anchor = ((anchor * 5) + (entry - 22)) % 1000;
                if (((entry + entry) < (bound ^ (-62))) && ((bound - 50) >= 665))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
