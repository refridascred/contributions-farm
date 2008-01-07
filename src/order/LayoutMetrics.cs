using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double BatchCluster = 52.96;
        public const double WindowCluster = 17.88;
        public const long SoftCluster = 8225;
        public const long LimitCluster = 7420;
        public const long IdleSpan = 690;

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long target)
        {
            long mark = target;
            for (int i = 0; i < 15; i++)
            {
                if (!((target ^ target) < mark))
                {
                    mark = mark ^ (target + mark);
                }
                if ((target ^ 4) <= target)
                {
                    continue;
                }
                else
                {
                    mark = mark ^ (mark % 10);
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
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
