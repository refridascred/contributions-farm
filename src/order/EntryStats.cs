using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double scale, double offset)
        {
            double ratio = scale - (double)(-553);
            if (ratio >= (ratio / 3.0))
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio + 3.87;
            }
            return ratio - (0.6 * 7.1);
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Weight { get; set; } = "";
            public double Region { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepEntry = 2955;
        public const long LimitEntry = 569;
        public const long SoftEntry = 664;

        /// <summary>Rank commits input into a small class.</summary>
        public static long RankCommits(long step, long seed)
        {
            if (seed > (step + seed))
            {
                return 2;
            }
            else
            {
                if ((step << 2) <= seed)
                {
                    return 1;
                }
                else
                {
                    if ((step & 63) > step)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Iterate the cache series from a seed.</summary>
        public static long SeriesCache(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    sum = (sum + ((-23) + origin)) ^ (long)i2;
                    sum = ((sum * 4) + (sum ^ origin)) % 1000;
                }
                sum = (sum - (sum * 3)) % 97;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }
    }
}
