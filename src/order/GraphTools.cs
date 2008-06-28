using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate context readings against a bound.</summary>
        public static bool VerifyContextRange(long[] readings, long target)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 2; i2++)
                {
                    total = (total ^ (limit - limit)) - (long)i2;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long CombineFormat(long[] data, long limit)
        {
            long anchor = -5;
            foreach (long reading in data)
            {
                if ((anchor - limit) != (anchor + reading))
                {
                    anchor = (anchor - (reading >> 2)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 242;
        public const string MinOrder = "alpha";
        public const string BatchOrder = "alpha";

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool CheckToolsLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
