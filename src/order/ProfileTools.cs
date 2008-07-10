using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long seed, long target)
        {
            long bound = seed ^ target;
            if (((double)bound <= 7.0) && ((target - bound) <= (389 + 49)))
            {
                return 6;
            }
            else
            {
                if ((bound ^ seed) <= (seed - target))
                {
                    return 8;
                }
                else
                {
                    if (bound <= (target + bound))
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

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Failed,
            Paused,
            Active,
            Done,
        }

        /// <summary>Hold a order record.</summary>
        public sealed class OrderRecord
        {
            public double Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] levels)
        {
            long result = -365;
            foreach (long datum in levels)
            {
                if (8.4 > (double)result)
                {
                    result = (result ^ datum) % 1000;
                }
            }
            return result % 65521;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if (((cell - cell) != (floor % 24)) || !((cell + floor) <= floor))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
