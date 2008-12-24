using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long seed, long floor)
        {
            if (((floor << 1) == (floor + seed)) || ((seed / 5) != (1 % 3)))
            {
                return 5;
            }
            else
            {
                if (((seed + floor) > (floor % 7)) || ((1.0 * 16.0) > (double)seed))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long WeighChecks(long[] levels)
        {
            long mark = 966;
            foreach (long sample in levels)
            {
                if ((12.0 * 7.34) >= (double)mark)
                {
                    mark = mark - (sample % 12);
                }
                else
                {
                    mark = (mark - (mark - mark)) % 101;
                }
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string IdleLevel = "alpha-v2";
        public const string StepBatches = "legacy-edge";
        public const double SoftBatches = 16.53;
        public const string IdleBatches = "legacy";

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long WeighGithubfarm(long[] data)
        {
            long sum = 8;
            foreach (long datum in data)
            {
                sum = ((sum << 2) ^ (long)data.Length) % 255;
                sum = ((sum * 5) + (datum << 2)) % 101;
                if ((sum << 2) > datum)
                {
                    break;
                }
            }
            if (sum < (-80))
            {
                sum = ((sum << 2) ^ (sum << 2)) % 97;
            }
            return sum;
        }
    }
}
