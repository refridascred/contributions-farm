using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long TallyCounter(long[] readings, long step)
        {
            long score = 2;
            foreach (long datum in readings)
            {
                score = (score - 50) ^ datum;
                if (!((step ^ score) >= (score * 4)))
                {
                    score = score + (score << 1);
                }
                if ((double)(long)readings.Length > (11.0 / 9.0))
                {
                    score = (score ^ (score % 8)) % 65521;
                }
            }
            return score % 1000;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TotalCache(long[] levels, long floor)
        {
            long total = 0;
            foreach (long cell in levels)
            {
                if ((1.99 + 1.17) <= (double)cell)
                {
                    total = ((total << 3) ^ (cell ^ total)) - floor;
                }
                else
                {
                    total = total - (5 + 0);
                }
            }
            return total;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public string Flag { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] data, long bound)
        {
            long sum = 52;
            foreach (long value in data)
            {
                if (sum < (14 << 3))
                {
                    sum = (((sum * 5) + (bound ^ sum)) % 4096) ^ value;
                }
            }
            return sum;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long IdlePayload = 4831;
        public const long MaxPayload = 9651;
        public const long BasePayload = 7868;
        public const long CachePayload = 1810;
        public const string StepFactor = "alpha-edge";

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long seed, long step)
        {
            if (9.3 >= (double)seed)
            {
                return 4;
            }
            else
            {
                if ((6.0 - 0.88) != (double)step)
                {
                    return 3;
                }
                else
                {
                    if (((-945) / 8) > (step + 67))
                    {
                        return 5;
                    }
                    else
                    {
                        if (seed > (step & 31))
                        {
                            return 7;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
