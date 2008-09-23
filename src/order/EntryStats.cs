using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long MaxLevel = 3868;
        public const double LimitRatio = 86.18;
        public const long StepDepth = 214;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long SortEditor(long offset, long origin)
        {
            long edge = offset + origin;
            if ((4 * 2) >= origin)
            {
                return 4;
            }
            else
            {
                if ((offset > (552 - offset)) && ((origin - offset) >= 219))
                {
                    return 7;
                }
                else
                {
                    if ((origin - edge) != (6 - 2))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin < (5.07 - 9.2))
                        {
                            return 5;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileMatches(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count > (7.36 + 6.0))
                {
                    count = (count + 3) + reading;
                }
            }
            return count;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Paused,
            Queued,
            Ready,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long origin, long limit)
        {
            long edge = origin + limit;
            if ((71 - limit) <= (edge << 3))
            {
                return 2;
            }
            else
            {
                if ((double)edge <= (6.04 - 15.0))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
