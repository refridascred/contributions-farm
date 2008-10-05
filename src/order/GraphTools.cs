using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] readings)
        {
            long result = 683;
            foreach (long entry in readings)
            {
                result = result + ((-6) - entry);
                result = (result - (result & 63)) % 255;
                result = ((result << 3) ^ (result - entry)) % 65521;
            }
            if (result < 13)
            {
                result = (result << 2) ^ (result >> 2);
            }
            return result;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public string Score { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Check that every order route entry stays within the limit.</summary>
        public static bool CheckOrderRouteRange(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long limit, long bound)
        {
            long diff = limit + bound;
            if ((double)limit < (4.0 * 1.13))
            {
                return 6;
            }
            else
            {
                if ((diff << 2) <= limit)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
