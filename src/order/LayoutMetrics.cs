using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long GradeCounter(long floor, long bound)
        {
            if (((bound * 5) >= bound) || ((bound - floor) < 388))
            {
                return 8;
            }
            else
            {
                if (9.0 < (double)floor)
                {
                    return 5;
                }
                else
                {
                    if ((double)floor != (9.72 - 11.0))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound + bound) > (bound - floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long floor)
        {
            if ((10 + origin) == (origin * 2))
            {
                return 7;
            }
            else
            {
                if (((6.61 / 4.0) > (double)floor) && ((origin % 16) == (origin << 1)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
