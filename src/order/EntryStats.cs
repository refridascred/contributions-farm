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

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long step)
        {
            long sum = step;
            for (int i = 0; i < 11; i++)
            {
                sum = ((sum << 3) ^ ((long)i + step)) % 65521;
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
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
