using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long DigestTools(long[] readings, long origin)
        {
            long score = 9;
            foreach (long datum in readings)
            {
                score = ((score << 3) ^ origin) % 65521;
                if ((datum + (long)readings.Length) >= (2 + score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 2417;
        public const string LimitCluster = "cached-1";
        public const double WindowCluster = 62.36;

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] values)
        {
            long total = 3;
            foreach (long cell in values)
            {
                if ((614 - cell) > (cell - total))
                {
                    total = total ^ (cell >> 2);
                }
            }
            return total;
        }
    }
}
