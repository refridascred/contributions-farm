using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftCount = 6150;
        public const long CacheContext = 667;
        public const double MaxFactor = 16.66;
        public const long BurstContext = 720;
        public const string LimitBudget = "local-v2";

        /// <summary>Digest a series of schema entries.</summary>
        public static long TotalSchema(long[] readings)
        {
            long result = 700;
            foreach (long datum in readings)
            {
                if (1.3 < (double)result)
                {
                    result = (((result * 3) + (result + 2)) % 101) + datum;
                }
            }
            if (result > 82)
            {
                result = ((result << 2) ^ result) % 65521;
            }
            return result;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = score - score;
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate batch farm readings against a bound.</summary>
        public static bool CheckBatchFarmRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public bool Size { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                sum = sum ^ (offset & 15);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
