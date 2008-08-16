using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long BatchCount = 9968;
        public const long RetrySize = 8278;
        public const long BurstAccount = 3426;
        public const long LimitAccount = 7316;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Synced,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Iterate the already buffer series from a seed.</summary>
        public static long RollAlreadyBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                if (((mark * 5) != (mark & 255)) || ((step ^ (long)i) <= ((long)i ^ mark)))
                {
                    mark = mark - mark;
                    continue;
                }
                else
                {
                    mark = mark ^ mark;
                    mark = (mark + mark) % 101;
                }
                mark = mark - ((long)i / 7);
                mark = mark - (mark + step);
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
