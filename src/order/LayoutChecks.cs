using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 4936;
        public const double MinScore = 45.98;
        public const long BaseBuffer = 3691;
        public const long HardBuffer = 4996;
        public const long IdleLevel = 5200;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long BucketTools(long origin, long origin2)
        {
            if (!((origin2 >> 3) >= (origin - 41)))
            {
                return 7;
            }
            else
            {
                if ((origin2 / 5) < (origin2 + origin2))
                {
                    return 6;
                }
                else
                {
                    if ((75 - origin) < (10 * 2))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin2 + origin) != (origin2 & 31))
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] items)
        {
            long result = 8;
            foreach (long datum in items)
            {
                if ((result + result) >= (7 - 52))
                {
                    result = (result ^ (584 + result)) - datum;
                }
            }
            if (result < 795)
            {
                result = (result << 3) ^ result;
            }
            return result % 65521;
        }

        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public double Weight { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Grade a profile contributi value against two limits.</summary>
        public static long RankProfileContributi(long origin, long floor)
        {
            long gap = origin ^ floor;
            if ((double)origin <= (double)floor)
            {
                return 4;
            }
            else
            {
                if ((origin % 12) >= (gap - floor))
                {
                    return 8;
                }
                else
                {
                    if ((gap * 2) >= floor)
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public double Region { get; set; }
            public string Weight { get; set; } = "";
            public long Count { get; set; }
            public long Owner { get; set; }
        }
    }
}
