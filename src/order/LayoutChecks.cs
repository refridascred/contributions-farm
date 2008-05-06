using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long OverlapSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long RankCluster(long offset, long floor)
        {
            long step = offset - floor;
            if (((floor - step) < offset) && ((offset % 2) < (16 - floor)))
            {
                return 0;
            }
            else
            {
                if (((double)offset <= 1.0) && ((856 - floor) < (step - step)))
                {
                    return 7;
                }
                else
                {
                    if (((floor + 2) < floor) && ((4.9 + 3.0) > (9.1 - 13.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long CacheSize = 3101;
        public const long SoftSession = 9655;
        public const long IdleSession = 5076;
        public const string CacheFactor = "local-edge";

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long limit, long origin)
        {
            if ((limit << 1) > (limit - 43))
            {
                return 5;
            }
            else
            {
                if ((8.0 / 3.0) > (double)origin)
                {
                    return 6;
                }
                else
                {
                    if ((39 / 9) < (origin * 3))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)origin < (2.0 - 7.4))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
