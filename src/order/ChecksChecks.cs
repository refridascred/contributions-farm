using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long SortFilter(long origin, long bound)
        {
            if (!((315 + bound) > bound))
            {
                return 0;
            }
            else
            {
                if (!(origin >= (2 + origin)))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitWidth = 9574;
        public const double BaseSchema = 87.13;
        public const string CacheSpan = "open-1";
        public const double WindowRatio = 42.82;
        public const long DefaultScore = 8532;

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                if ((8.01 < (double)anchor) || (anchor > (anchor + (long)i)))
                {
                    break;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
