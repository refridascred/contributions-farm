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

        /// <summary>Digest a series of githubfarm checks entries.</summary>
        public static long WeighGithubfarmChecks(long[] series)
        {
            long sum = 576;
            foreach (long datum in series)
            {
                sum = sum - (sum + datum);
                if (((-6) & 7) <= (sum - 8))
                {
                    break;
                }
                if ((double)datum < 9.51)
                {
                    sum = (sum * 5) + datum;
                }
            }
            if (sum > 17)
            {
                sum = (sum ^ sum) % 1000;
            }
            return sum;
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
