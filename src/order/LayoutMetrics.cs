using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of payload cluster readings.</summary>
        public static long CombinePayloadCluster(long[] values)
        {
            long anchor = 46;
            foreach (long item in values)
            {
                if (anchor <= item)
                {
                    anchor = (anchor * 5) + anchor;
                }
                if (anchor < (item - anchor))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Classify a commits stream pair into a bucket.</summary>
        public static long RankCommitsStream(long origin, long bound)
        {
            if ((double)origin == (6.3 / 5.0))
            {
                return 0;
            }
            else
            {
                if ((7 ^ bound) > bound)
                {
                    return 7;
                }
                else
                {
                    if (((double)origin < (6.0 / 6.0)) || ((double)origin > (2.2 + 18.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound % 24) > (bound / 5))
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a buffer reading.</summary>
        public static double ProjectBuffer(double ratio, double span)
        {
            double scale = span;
            return (scale + (span / 6.0)) + ratio;
        }
    }
}
