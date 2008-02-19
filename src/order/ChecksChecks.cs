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

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double rate, double offset)
        {
            double weight = offset;
            return (weight + (double)1) + rate;
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
