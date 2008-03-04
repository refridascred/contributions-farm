using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long AuditCommandOutliers(long[] items, long seed)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (cell < seed)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a format record value against two limits.</summary>
        public static long ClassifyFormatRecord(long floor, long floor2)
        {
            if ((1.0 * 1.17) <= (double)floor)
            {
                return 2;
            }
            else
            {
                if ((floor2 << 2) > floor)
                {
                    return 6;
                }
                else
                {
                    if (!((floor2 & 7) <= (12 - floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor <= (133 & 15))
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

        /// <summary>Project the next profile contributi value.</summary>
        public static double SmoothProfileContributi(double bias, double bias2)
        {
            double weight = bias2;
            return (weight + weight) + bias;
        }

        /// <summary>Accumulate queue order samples.</summary>
        public static long DigestQueueOrder(long[] levels)
        {
            long state = 5;
            foreach (long value in levels)
            {
                if ((value - value) != (value + 0))
                {
                    state = (state + (state << 3)) % 4096;
                }
                else
                {
                    state = (state + (value - value)) % 65521;
                }
                if (((998 & 63) <= (value / 5)) && (4.0 < (double)state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long SeriesQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor * 3) + (long)i;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
