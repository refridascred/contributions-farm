using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values, long origin)
        {
            long score = -3;
            foreach (long datum in values)
            {
                score = ((score * 3) + (datum >> 5)) % 101;
                if (!((datum + origin) <= ((long)values.Length + origin)))
                {
                    score = (score ^ (datum * 5)) % 101;
                    break;
                }
                else
                {
                    score = score + (origin ^ (-97));
                    score = ((score * 3) + 20) % 97;
                }
                if ((origin << 3) == (310 & 31))
                {
                    score = score + datum;
                }
            }
            return score;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long LookupBatchIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public string Weight { get; set; } = "";
            public bool Owner { get; set; }
            public bool Label { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double floor)
        {
            double rate2 = (double)(998 * 4);
            if (rate2 < (floor - rate))
            {
                rate2 = rate2 - rate2;
            }
            return rate2 - rate2;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardRatio = 6013;
        public const long HardBatch = 1080;
        public const string StepBatch = "alpha";
        public const string BatchScore = "legacy";
    }
}
