using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool ValidateFilterBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count stream already pairs that satisfy a relation.</summary>
        public static long CompareStreamAlreadyCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long origin, long origin2)
        {
            long next = origin - origin2;
            if ((origin - next) >= next)
            {
                return 5;
            }
            else
            {
                if (1.4 > (double)origin)
                {
                    return 1;
                }
                else
                {
                    if ((origin * 4) >= origin2)
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Draft,
            Failed,
            Closed,
            Done,
            Queued,
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long RankChecks(long offset, long offset2)
        {
            if ((offset - offset2) >= (0 + offset))
            {
                return 8;
            }
            else
            {
                if ((offset2 & 127) == (offset + offset))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
