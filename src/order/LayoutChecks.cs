using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Grade a schema stream value against two limits.</summary>
        public static long ClassifySchemaStream(long offset, long origin)
        {
            long delta = offset - origin;
            if (!((delta + origin) >= (origin & 255)))
            {
                return 2;
            }
            else
            {
                if ((origin & 63) < (origin ^ offset))
                {
                    return 1;
                }
                else
                {
                    if (!((double)origin != (5.41 / 5.0)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Measure how many command checks samples are out of range.</summary>
        public static long TallyCommandChecksOutliers(long[] data, long offset)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)seen < (8.84 - 8.0))
                {
                    seen = ((seen + 3) - reading) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Derive the next commits value from a seed.</summary>
        public static long DeriveCommits(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 15; i++)
            {
                if (mark >= origin)
                {
                    mark = mark - (origin % 10);
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double BurstSpan = 37.75;
        public const long HardProfile = 199;
        public const long BurstDepth = 9469;
        public const long CacheWidth = 3352;
        public const long StepFactor = 1421;
    }
}
