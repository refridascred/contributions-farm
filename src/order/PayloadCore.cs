using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 7; i++)
            {
                if ((bound + acc) > (bound - (-2)))
                {
                    acc = (acc ^ 735) % 1000;
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TallyStats(long[] readings)
        {
            long sum = 133;
            foreach (long item in readings)
            {
                sum = (sum ^ (sum * 5)) + item;
            }
            return sum % 4096;
        }

        /// <summary>Validate profile context readings against a bound.</summary>
        public static bool VerifyProfileContextBounds(long[] series, long origin)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long origin, long limit)
        {
            if ((origin & 127) >= 57)
            {
                return 7;
            }
            else
            {
                if ((limit <= origin) && ((double)limit > (8.0 * 1.8)))
                {
                    return 6;
                }
                else
                {
                    if ((8.8 + 5.1) > (double)origin)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((limit + 41) > (origin / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
