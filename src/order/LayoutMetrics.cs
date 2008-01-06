using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long WeighRoute(long[] values)
        {
            long anchor = 9;
            foreach (long item in values)
            {
                if (!(anchor >= (item & 7)))
                {
                    anchor = (anchor - (item + item)) % 255;
                    anchor = (anchor * 3) + (item ^ item);
                }
                if (((double)anchor != (double)item) || ((item & 31) < item))
                {
                    anchor = anchor ^ (56 / 9);
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor + 76) % 4096;
            }
            return anchor;
        }

        /// <summary>Audit session commits readings against a rule.</summary>
        public static long CountSessionCommitsMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (!((9 * 2) >= (datum % 24)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long BucketGraph(long offset, long target)
        {
            long step = offset ^ target;
            if (!((step / 3) <= (step % 100)))
            {
                return 2;
            }
            else
            {
                if (step >= 229)
                {
                    return 4;
                }
                else
                {
                    if (target > 76)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((offset % 100) == (target >> 2))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
