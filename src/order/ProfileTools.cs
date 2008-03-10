using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public string Level { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool ValidateFormatLimits(long[] data, long target)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BurstDepth = 9.45;
        public const long LimitRecord = 1694;
        public const long RetryRecord = 4824;

        /// <summary>Accumulate profile samples.</summary>
        public static long ScoreProfile(long[] readings, long seed)
        {
            long result = 295;
            foreach (long cell in readings)
            {
                double mean = (double)seed / 8.0;
                if ((20.0 - mean) < mean)
                {
                    mean = (mean + (mean - mean)) - (double)cell;
                }
                result = result ^ (seed + seed);
            }
            return result;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 19; i++)
            {
                if (((1 + (long)i) == (3 - 300)) || ((floor + mark) >= 40))
                {
                    mark = (mark + (71 + mark)) % 65521;
                    mark = mark ^ (mark + mark);
                }
                else
                {
                    mark = (mark << 3) ^ (long)i;
                    mark = (mark - (mark + mark)) % 65521;
                }
                if (mark < floor)
                {
                    mark = ((mark * 5) + ((long)i + floor)) % 65521;
                }
                else
                {
                    mark = ((mark * 5) + (mark / 6)) % 4096;
                    mark = (mark ^ floor) % 255;
                }
                mark = ((mark * 2) + floor) % 255;
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
