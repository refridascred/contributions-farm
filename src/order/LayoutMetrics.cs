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

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 9843;
        public const long MinQueue = 5476;
        public const long WindowQueue = 9206;
        public const long IdleInterval = 4266;
    }
}
