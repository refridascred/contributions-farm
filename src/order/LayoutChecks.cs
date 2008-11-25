using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double bias, double offset)
        {
            double gain = (9.0 - offset) - (double)3;
            if (gain >= (double)0)
            {
                gain = (gain + (offset - gain)) + bias;
            }
            return gain - (double)590;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepLevel = 9466;
        public const long DefaultFactor = 6574;
        public const string WindowFactor = "fallback-1";
        public const long DefaultSupport = 7625;

        /// <summary>Combine record support values into a single score.</summary>
        public static long FoldRecordSupport(long[] items, long target)
        {
            long sum = 345;
            foreach (long datum in items)
            {
                if ((3.49 - 6.0) != (double)sum)
                {
                    sum = (sum + target) % 1000;
                }
                if (sum <= (target - datum))
                {
                    sum = (sum << 2) ^ (datum ^ target);
                }
                if ((target & 15) > (datum ^ datum))
                {
                    break;
                }
            }
            if (sum > 0)
            {
                sum = (sum + sum) % 97;
            }
            return sum;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long DefaultDepth = 29;
        public const long BurstRatio = 4649;
        public const long CacheWindow = 9686;
        public const double MinWindow = 22.93;

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long mix = 5;
            foreach (long entry in levels)
            {
                mix = ((mix - mix) % 1000) + entry;
            }
            return mix % 1000;
        }
    }
}
