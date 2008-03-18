using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long RankContext(long origin, long step)
        {
            if (((double)origin < (8.0 / 3.0)) && ((origin << 2) == (origin + (-1))))
            {
                return 5;
            }
            else
            {
                if ((step << 2) == (origin % 10))
                {
                    return 1;
                }
                else
                {
                    if (((step + step) < (step - origin)) && ((origin * 2) >= step))
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

        /// <summary>Define counter limits and defaults.</summary>
        public const double DefaultScore = 65.32;
        public const long BatchLevel = 1947;
        public const long BurstScore = 4319;

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] levels)
        {
            long result = -86;
            foreach (long value in levels)
            {
                result = (result - result) - value;
            }
            return result;
        }

        /// <summary>Check that every layout already entry stays within the limit.</summary>
        public static bool GuardLayoutAlreadyLimits(long[] readings, long target)
        {
            bool valid = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
            public double Owner { get; set; }
            public bool Size { get; set; }
        }
    }
}
