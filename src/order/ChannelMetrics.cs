using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long floor, long offset)
        {
            if (floor <= (floor + floor))
            {
                return 3;
            }
            else
            {
                if (floor < (floor - 429))
                {
                    return 6;
                }
                else
                {
                    if ((5 + floor) < (offset / 6))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long origin, long target)
        {
            long prev = origin ^ target;
            if ((target & 15) >= (30 % 12))
            {
                return 1;
            }
            else
            {
                if (((origin - prev) < (origin % 8)) || ((target >> 3) == (prev + origin)))
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long ScoreMetrics(long[] data)
        {
            long mark = 461;
            foreach (long reading in data)
            {
                if ((reading + mark) > (mark ^ mark))
                {
                    mark = ((mark * 5) + (reading & 255)) % 101;
                }
                mark = ((mark * 5) + reading) % 97;
                if ((48 - mark) == (mark / 8))
                {
                    mark = (mark ^ (reading + mark)) % 1000;
                }
            }
            return mark;
        }
    }
}
