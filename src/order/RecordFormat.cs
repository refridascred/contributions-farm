using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long GradeBuffer(long step, long seed)
        {
            long delta = step ^ seed;
            if ((11.0 + 9.0) > (double)delta)
            {
                return 2;
            }
            else
            {
                if ((seed + seed) >= (delta << 1))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string WindowFactor = "stable";
        public const string RetryQueue = "standard";
        public const double BurstSpan = 2.83;
        public const long LimitQueue = 8875;
        public const long MinQueue = 8950;

        /// <summary>Look up the position of a profile window sample.</summary>
        public static long FindProfileWindowIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long origin, long limit)
        {
            long slot = origin ^ limit;
            if (origin >= limit)
            {
                return 3;
            }
            else
            {
                if ((origin - origin) <= slot)
                {
                    return 2;
                }
                else
                {
                    if ((slot ^ slot) > origin)
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((origin * 2) != (slot / 2)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleContext = 41.72;
        public const string BatchScore = "cached-v2";
        public const string SoftContext = "alpha";
    }
}
