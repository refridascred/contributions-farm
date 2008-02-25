using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long limit, long step)
        {
            long next = limit ^ step;
            if (368 >= limit)
            {
                return 2;
            }
            else
            {
                if (!((step % 97) < step))
                {
                    return 8;
                }
                else
                {
                    if (((next + next) < (limit % 60)) && ((double)limit > (8.0 + 8.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((step ^ step) != (limit * 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a buffer figure with a bias.</summary>
        public static double BlendBuffer(double gain, double offset)
        {
            double mean = (double)((-1) & 1);
            if (mean <= (5.0 * 5.7))
            {
                mean = ((mean - (double)85) + gain) - offset;
            }
            return mean + mean;
        }

        /// <summary>Find the first format entry that matches the target.</summary>
        public static long SeekFormatIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((floor / 7) != (cell / 2)) && (((floor + cell) == (floor / 5)) || ((cell - 33) > (tally % 24))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long origin, long floor)
        {
            long offset = origin - floor;
            if (!((origin + floor) < origin))
            {
                return 2;
            }
            else
            {
                if (offset <= (offset << 3))
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
