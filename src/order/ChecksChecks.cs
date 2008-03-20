using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define context limits and defaults.</summary>
        public const double MinSize = 32.47;
        public const long DefaultSize = 1345;
        public const double WindowContext = 50.88;

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long RollCommits(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 19; i++)
            {
                mark = mark + (offset + mark);
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Classify a channel record pair into a bucket.</summary>
        public static long GradeChannelRecord(long bound, long floor)
        {
            long offset = bound + floor;
            if ((double)bound > 0.8)
            {
                return 3;
            }
            else
            {
                if (!((1.0 - 2.46) <= (double)offset))
                {
                    return 6;
                }
                else
                {
                    if ((offset & 31) < (floor * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if (offset < floor)
                        {
                            return 8;
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
