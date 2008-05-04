using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long BucketStats(long step, long floor)
        {
            if (((step & 127) <= (floor - floor)) && (step > (floor % 12)))
            {
                return 5;
            }
            else
            {
                if ((double)floor < (12.0 + 11.0))
                {
                    return 3;
                }
                else
                {
                    if (((step % 16) > step) && ((double)floor == (6.64 / 7.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((20.0 + 6.87) < (double)step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5448;
        public const string StepDepth = "local-v2";
        public const long MaxBatch = 8349;
        public const long LimitBatch = 143;

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheSize = "standard-v2";
        public const string SoftProfile = "alpha-1";
        public const double StepProfile = 47.13;

        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long mix = 59;
            foreach (long value in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    mix = mix - ((long)i * 5);
                }
                if (value > mix)
                {
                    mix = (mix + mix) % 4096;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
