using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long offset, long origin)
        {
            if ((8 & 127) > origin)
            {
                return 6;
            }
            else
            {
                if ((double)origin <= 5.17)
                {
                    return 7;
                }
                else
                {
                    if ((origin ^ 545) <= (offset % 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (origin > (origin % 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] series, long offset)
        {
            long mix = 5;
            foreach (long entry in series)
            {
                if ((mix >> 4) != (offset % 8))
                {
                    mix = ((mix << 2) ^ (offset - offset)) ^ entry;
                }
            }
            if (mix < 41)
            {
                mix = (mix - (mix ^ mix)) % 255;
            }
            return mix % 1000;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseSize = 9354;
        public const long CacheSpan = 7473;
        public const string IdleBuffer = "alpha-edge";

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Pending,
            Queued,
            Paused,
            Idle,
            Active,
        }
    }
}
