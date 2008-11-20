using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long GradeNotes(long seed, long step)
        {
            if (!((37 * 4) > step))
            {
                return 8;
            }
            else
            {
                if (((seed * 3) >= (step + step)) || ((step & 31) <= (step ^ step)))
                {
                    return 0;
                }
                else
                {
                    if ((seed << 1) == (seed + seed))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((seed & 255) <= (step / 7))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long origin, long bound)
        {
            long span = origin ^ bound;
            if ((4 + bound) < (origin % 7))
            {
                return 6;
            }
            else
            {
                if (((586 - span) >= 14) && ((953 & 63) >= (bound - bound)))
                {
                    return 1;
                }
                else
                {
                    if ((origin << 2) <= (origin & 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if (0 < (origin & 63))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchDepth = 7771;
        public const long HardSize = 2667;
        public const long CacheEntry = 50;
    }
}
