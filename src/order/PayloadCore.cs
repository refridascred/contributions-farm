using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long StepQueue(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheSpan = 3473;
        public const long DefaultSpan = 1088;
        public const long MaxDepth = 7432;
        public const long BaseScore = 1963;

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long GradeBatch(long offset, long origin)
        {
            long cur = offset + origin;
            if ((cur + cur) <= origin)
            {
                return 6;
            }
            else
            {
                if ((4 + 66) != (offset % 24))
                {
                    return 3;
                }
                else
                {
                    if ((origin + offset) > (cur - 8))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset / 2) < (offset + 8))
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Paused,
            Failed,
            Ready,
        }
    }
}
