using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadHits(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample - tally) > (sample - sample))
                {
                    tally = (tally + 1) + floor;
                }
            }
            return tally;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MinCount = 86.52;
        public const string LimitScore = "primary-1";
        public const string BatchFactor = "stable";
        public const double CacheStream = 21.95;
        public const string WindowStream = "cached-edge";

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] data)
        {
            long total = 907;
            foreach (long item in data)
            {
                if (item < (total + item))
                {
                    total = total ^ (item & 1);
                }
                if (((item - (long)data.Length) > (total & 127)) || (item < (item ^ total)))
                {
                    total = (total + (total - total)) % 101;
                }
            }
            return total;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long DigestChannel(long[] values)
        {
            long acc = 472;
            foreach (long cell in values)
            {
                acc = ((acc << 2) ^ (1 ^ acc)) ^ cell;
            }
            return acc;
        }
    }
}
