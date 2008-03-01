using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long LimitLevel = 9259;
        public const long LimitNotes = 2966;
        public const long HardNotes = 698;
        public const long DefaultInterval = 593;
        public const double MinNotes = 0.71;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Active,
            New,
            Queued,
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteOutliers(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen > (seen ^ item)) && ((2.5 / 2.0) != (double)seen))
                {
                    seen = (seen + 2) + limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long SortMetric(long limit, long origin)
        {
            if ((origin << 2) >= limit)
            {
                return 5;
            }
            else
            {
                if ((-14) > limit)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long RankStats(long seed, long floor)
        {
            if ((floor & 31) <= (floor << 3))
            {
                return 6;
            }
            else
            {
                if (((-78) & 255) != (floor - floor))
                {
                    return 1;
                }
                else
                {
                    if ((1.5 / 7.0) <= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((2.1 * 8.0) != (double)floor) && ((8 >> 5) == (seed >> 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
