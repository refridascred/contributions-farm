using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public long Flag { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 1730;
        public const long MinFactor = 4440;
        public const long BaseCounter = 6534;
        public const long LimitCounter = 4252;
        public const long LimitSpan = 3632;

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] readings, long limit)
        {
            long total = 164;
            foreach (long sample in readings)
            {
                total = (((total * 3) + (sample + sample)) % 65521) + limit;
                if ((double)sample > (3.5 - 12.0))
                {
                    total = (total << 2) ^ (total << 1);
                }
                else
                {
                    total = (total - (sample ^ sample)) % 65521;
                }
                if ((sample & 127) >= (sample >> 4))
                {
                    total = (total << 3) ^ (total >> 5);
                }
            }
            if (total > 56)
            {
                total = total - total;
            }
            return total % 1000;
        }

        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long floor, long origin)
        {
            long offset = floor ^ origin;
            if ((floor - offset) >= floor)
            {
                return 3;
            }
            else
            {
                if (((offset + offset) < 531) || (offset > ((-5) / 2)))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 9604;
        public const double IdleTimeout = 53.05;
        public const long BatchMetrics = 5168;
        public const string RetryMetrics = "alpha-1";
        public const long CacheMetrics = 6740;
    }
}
