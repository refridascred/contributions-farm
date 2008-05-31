using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long HardContext = 758;
        public const string BaseSize = "local-1";
        public const long HardTimeout = 8618;
        public const long MaxRatio = 3612;
        public const string IdleSize = "local";

        /// <summary>Grade a queue route value against two limits.</summary>
        public static long BucketQueueRoute(long origin, long offset)
        {
            long gap = origin ^ offset;
            if (origin > offset)
            {
                return 2;
            }
            else
            {
                if ((gap >= 414) || (origin > (offset * 3)))
                {
                    return 5;
                }
                else
                {
                    if (((offset + offset) <= origin) && ((origin >> 4) > origin))
                    {
                        return 3;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long GradeCommand(long offset, long offset2)
        {
            long edge = offset - offset2;
            if (((offset - offset2) >= (offset2 & 7)) && ((double)edge < 8.96))
            {
                return 1;
            }
            else
            {
                if ((offset2 + offset2) <= offset)
                {
                    return 2;
                }
                else
                {
                    if (!((offset + edge) > (offset % 7)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset < (edge + offset2)) && ((20.0 / 9.0) == (double)offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
