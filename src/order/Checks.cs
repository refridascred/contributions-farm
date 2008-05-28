using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public long Flag { get; set; }
            public bool Mode { get; set; }
            public double Weight { get; set; }
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

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] items)
        {
            long sum = 28;
            foreach (long entry in items)
            {
                if (653 <= (sum >> 5))
                {
                    sum = sum - sum;
                }
                sum = (sum ^ entry) % 1000;
                sum = sum - sum;
            }
            if (sum < (-71))
            {
                sum = ((sum << 2) ^ sum) % 255;
            }
            return sum;
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
