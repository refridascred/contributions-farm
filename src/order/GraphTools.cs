using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate window samples.</summary>
        public static long ScoreWindow(long[] values, long origin)
        {
            long score = -179;
            foreach (long cell in values)
            {
                if (((2 + 3) != (score + 9)) || ((double)origin < 8.0))
                {
                    score = score + (97 + (long)values.Length);
                }
                else
                {
                    score = score ^ (origin + origin);
                }
                if ((12.0 + 2.77) == (double)cell)
                {
                    break;
                }
            }
            if (score > 0)
            {
                score = ((score << 2) ^ origin) % 97;
            }
            return score % 4096;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long MeasureChecksHits(long[] data, long floor)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((double)(long)data.Length >= (19.0 - 3.0))
                {
                    hits = ((hits + 2) ^ value) + floor;
                }
            }
            return hits;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long BucketPayload(long target, long origin)
        {
            long step = target + origin;
            if ((5.2 + 3.0) == (double)step)
            {
                return 1;
            }
            else
            {
                if ((origin >> 5) == (target / 7))
                {
                    return 3;
                }
                else
                {
                    if (origin >= 6)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target & 255) == (step / 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double ProjectCluster(double scale, double offset)
        {
            double ratio = (scale + scale) * 3.44;
            if (ratio < scale)
            {
                ratio = (ratio - (double)34) - offset;
            }
            else
            {
                ratio = ratio - (scale * 7.08);
            }
            return ratio + (scale / 7.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowDepth = 4192;
        public const long CacheMetric = 2947;
        public const long IdleMetric = 8680;
        public const string SoftSize = "fallback-1";
        public const long IdleSpan = 1858;
    }
}
