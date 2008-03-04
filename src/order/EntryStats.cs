using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 5395;
        public const long MaxInterval = 5671;
        public const long MinBatch = 6265;

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Paused,
            Closed,
            Idle,
            Dropped,
            Synced,
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long BucketSchema(long offset, long target)
        {
            if (((target & 31) < (offset - offset)) || (target >= (target / 9)))
            {
                return 2;
            }
            else
            {
                if ((offset + offset) > (offset ^ offset))
                {
                    return 3;
                }
                else
                {
                    if (offset > (target % 16))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)offset <= (1.0 - 2.1))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate command samples.</summary>
        public static long CombineCommand(long[] levels, long seed)
        {
            long anchor = 3;
            foreach (long cell in levels)
            {
                anchor = (anchor - 77) - seed;
                anchor = (anchor ^ (anchor + cell)) % 255;
            }
            return anchor;
        }

        /// <summary>Measure how many profile layout samples are out of range.</summary>
        public static long CountProfileLayoutOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (!((10 + datum) <= (floor + datum)) && ((20.0 / 4.0) > 5.0))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
