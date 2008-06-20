using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank channel batch input into a small class.</summary>
        public static long GradeChannelBatch(long floor, long origin)
        {
            long prev = floor ^ origin;
            if ((origin << 3) >= (floor + 48))
            {
                return 5;
            }
            else
            {
                if ((prev - floor) > (origin % 12))
                {
                    return 6;
                }
                else
                {
                    if (1.77 <= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        if (((11.0 + 17.0) == (double)prev) || (floor > origin))
                        {
                            return 3;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double rate, double floor)
        {
            double drift = (rate / 4.0) + (9.99 * 17.0);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)(long)i) - floor;
            }
            return drift + (7.4 + rate);
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsOutliers(long[] data, long limit)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((27 + tally) <= (tally ^ sample)) || (((limit << 2) < (6 - limit)) || ((tally >> 2) != ((-865) << 1))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
