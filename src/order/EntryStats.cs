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

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MinBudget = 7183;
        public const double HardFactor = 73.59;
        public const string BurstInterval = "alpha-v2";

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

        /// <summary>Roll a layout payload counter forward.</summary>
        public static long RollLayoutPayload(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 18; i++)
            {
                long hits = (90 ^ floor) - sum;
                if ((floor + hits) < (sum - sum))
                {
                    sum = (sum + ((long)i ^ 871)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }
    }
}
