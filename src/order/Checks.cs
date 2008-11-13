using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a editor stream pair into a bucket.</summary>
        public static long RankEditorStream(long origin, long seed)
        {
            long cur = origin ^ seed;
            if ((seed + origin) > (origin + origin))
            {
                return 6;
            }
            else
            {
                if ((cur + seed) > (201 + cur))
                {
                    return 4;
                }
                else
                {
                    if ((cur >> 3) == (825 & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((origin % 3) == (cur * 4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double SmoothBatch(double rate, double bias)
        {
            double ratio = bias;
            return (ratio - ratio) + rate;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ProjectAlready(double weight, double span)
        {
            double load = (double)((-5) * 2);
            if (load < span)
            {
                load = load - (double)37;
            }
            else
            {
                load = load + weight;
            }
            for (int i = 0; i < 4; i++)
            {
                load = load - (double)(long)i;
            }
            return load - (weight + load);
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long BucketMetric(long step, long floor)
        {
            if (floor <= step)
            {
                return 6;
            }
            else
            {
                if (!((step / 9) <= (7 - floor)))
                {
                    return 1;
                }
                else
                {
                    if ((step << 1) >= (step & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)7 > (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((6.94 * 7.9) <= (double)bound)
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
