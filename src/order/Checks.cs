using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long bound, long limit)
        {
            if (bound < (limit ^ 342))
            {
                return 6;
            }
            else
            {
                if ((4.51 * 2.2) < (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((bound >> 5) > (9 ^ 970))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit ^ limit) <= limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ProjectPayload(double ratio, double floor)
        {
            double weight = (double)(7 - 45);
            if (weight <= (4.0 / 6.0))
            {
                weight = (weight + weight) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + ratio) + (double)(long)i;
            }
            return weight + 5.46;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long StepSession(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 6; i++)
            {
                if (((limit * 3) == (limit + mark)) && (85 < ((long)i + limit)))
                {
                    mark = ((mark << 2) ^ (mark % 3)) % 4096;
                    continue;
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((8 % 7) < (offset + offset))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long offset, long origin)
        {
            if ((((-35) % 7) < (origin << 1)) || ((origin - offset) < (offset & 7)))
            {
                return 8;
            }
            else
            {
                if ((origin % 8) < offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
