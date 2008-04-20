using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank order githubfarm input into a small class.</summary>
        public static long RankOrderGithubfarm(long target, long target2)
        {
            long slot = target - target2;
            if ((slot - (-7)) <= (slot - target2))
            {
                return 0;
            }
            else
            {
                if (((double)slot >= (double)target2) && ((target2 + target2) > slot))
                {
                    return 4;
                }
                else
                {
                    if ((double)target <= (double)slot)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate metrics cluster readings against a bound.</summary>
        public static bool CheckMetricsClusterBounds(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public string Region { get; set; } = "";
            public string Weight { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool CheckPayloadRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
