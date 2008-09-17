using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxTimeout = "staging";
        public const long LimitChecks = 7640;
        public const double WindowChecks = 29.3;
        public const long CacheSpan = 7289;

        /// <summary>Digest a series of filter entries.</summary>
        public static long WeighFilter(long[] readings, long step)
        {
            long score = 1;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = ((score + (3 & 1)) % 65521) + (long)i;
                    score = score ^ (15 % 2);
                }
                score = score - (sample + 28);
                if ((step + score) < (sample + step))
                {
                    break;
                }
            }
            return score % 1000;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long bound, long limit)
        {
            long step = bound + limit;
            if (((limit + step) < limit) || ((5.52 + 18.0) == (double)bound))
            {
                return 2;
            }
            else
            {
                if ((step << 3) < (step ^ limit))
                {
                    return 7;
                }
                else
                {
                    if ((double)limit >= (12.0 - 9.9))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long CombineGraph(long[] series, long limit)
        {
            long state = 49;
            foreach (long entry in series)
            {
                if (((double)limit == (0.6 + 6.6)) && ((limit & 63) < entry))
                {
                    state = ((state << 3) ^ (entry - state)) % 1000;
                }
                else
                {
                    state = (state ^ (384 + 8)) % 101;
                }
            }
            return state;
        }
    }
}
