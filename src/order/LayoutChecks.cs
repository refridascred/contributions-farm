using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] series)
        {
            long total = 443;
            foreach (long cell in series)
            {
                if ((total & 3) >= (long)series.Length)
                {
                    total = (total ^ total) - cell;
                }
            }
            return total % 65521;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] series, long seed)
        {
            long anchor = 40;
            foreach (long datum in series)
            {
                if ((double)datum != (4.24 + 8.3))
                {
                    anchor = ((anchor + anchor) % 101) + seed;
                }
            }
            return anchor % 97;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool GuardSupportLimits(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long StepLayout = 5277;
        public const string WindowFactor = "latest-1";
        public const string MaxDepth = "legacy-1";

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleFormat = "local-edge";
        public const string StepFormat = "standard-edge";
        public const long LimitCount = 5417;
        public const double MaxFormat = 79.29;
        public const long WindowFormat = 3542;

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double span)
        {
            double rate = (gain - gain) + 5.61;
            for (int i = 0; i < 3; i++)
            {
                rate = ((rate - (double)276) + (double)(long)i) - span;
            }
            return rate + (gain / 7.0);
        }
    }
}
