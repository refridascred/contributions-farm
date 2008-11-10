using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] series, long offset)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the schema metric entries that pass the check.</summary>
        public static long TallySchemaMetricGaps(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count - count) > (cell + count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long ClassifyChannel(long limit, long limit2)
        {
            if ((limit - limit2) > limit)
            {
                return 7;
            }
            else
            {
                if (((-849) >> 5) != (limit2 + limit))
                {
                    return 6;
                }
                else
                {
                    if ((5 % 16) <= (limit + limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Region { get; set; }
            public double Label { get; set; }
            public string Level { get; set; } = "";
            public string Flag { get; set; } = "";
        }
    }
}
