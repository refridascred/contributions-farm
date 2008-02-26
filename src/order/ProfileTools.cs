using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ProjectContext(double ratio, double span)
        {
            double weight = 9.14 - ratio;
            if (weight < (ratio / 5.0))
            {
                weight = (weight - weight) - span;
            }
            else
            {
                weight = weight + (double)163;
            }
            return weight + weight;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long GradeBatches(long step, long target)
        {
            long lane = step - target;
            if (((19.0 + 3.3) >= (7.4 + 8.55)) && ((target ^ lane) != (target * 2)))
            {
                return 6;
            }
            else
            {
                if (((lane - step) < (93 - (-7))) && ((lane + target) < (step + lane)))
                {
                    return 2;
                }
                else
                {
                    if ((1.0 * 17.0) < (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if (target >= (lane & 127))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a queue route sample.</summary>
        public static long LocateQueueRouteIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long TallyLayoutMatches(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((origin + origin) <= cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 9952;
        public const string StepSize = "stable-edge";
        public const long SoftWidth = 9686;
    }
}
