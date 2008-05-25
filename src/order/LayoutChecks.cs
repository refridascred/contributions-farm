using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long origin, long offset)
        {
            long offset2 = origin - offset;
            if ((origin + offset) >= (origin - offset2))
            {
                return 8;
            }
            else
            {
                if (!(offset2 < (origin & 127)))
                {
                    return 4;
                }
                else
                {
                    if ((offset2 % 8) == (offset / 6))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin - 43) <= (offset - offset)) || ((origin - origin) == (2 + 770)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long SeriesMetrics(long step)
        {
            long mark = step;
            for (int i = 0; i < 13; i++)
            {
                if (!((long)i <= (step & 255)))
                {
                    mark = ((mark * 3) + mark) % 101;
                }
                else
                {
                    mark = ((mark << 3) ^ (step >> 4)) % 255;
                }
                mark = (mark + step) % 97;
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Classify a session queue pair into a bucket.</summary>
        public static long SortSessionQueue(long seed, long limit)
        {
            if (((limit - limit) == (seed - 42)) && ((6.47 + 1.57) == (double)seed))
            {
                return 0;
            }
            else
            {
                if ((seed % 5) < seed)
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
