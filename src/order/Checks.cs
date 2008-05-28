using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 14; i++)
            {
                carry = (carry * 5) + carry;
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Derive the next githubfarm filter value from a seed.</summary>
        public static long SeriesGithubfarmFilter(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin + 3) > (42 & 31))
                {
                    anchor = (anchor + anchor) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long SortToken(long offset, long limit)
        {
            long lane = offset - limit;
            if (!((offset & 255) > (offset ^ offset)))
            {
                return 4;
            }
            else
            {
                if ((lane + lane) < (lane + 79))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Validate support metrics readings against a bound.</summary>
        public static bool GuardSupportMetricsBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] values, long bound)
        {
            long result = -303;
            foreach (long reading in values)
            {
                result = (result + (result >> 4)) ^ reading;
            }
            if (result < 285)
            {
                result = ((result << 3) ^ (bound ^ result)) % 255;
            }
            return result;
        }
    }
}
