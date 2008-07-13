using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a batches stream value against two limits.</summary>
        public static long BucketBatchesStream(long origin, long offset)
        {
            long diff = origin ^ offset;
            if (((origin + offset) > (diff + diff)) && ((diff - diff) == (offset + origin)))
            {
                return 0;
            }
            else
            {
                if ((offset & 15) >= origin)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleTimeout = 9861;
        public const long IdleAlready = 6970;
        public const double BaseAlready = 31.88;
        public const double MaxAlready = 45.67;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] samples, long step)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (85 <= reading)
                {
                    matches = (matches + 3) + step;
                }
            }
            return matches;
        }
    }
}
