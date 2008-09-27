using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long step, long offset)
        {
            if ((8.31 * 7.17) != (double)offset)
            {
                return 8;
            }
            else
            {
                if (((offset + step) <= offset) && ((step << 3) >= (step % 10)))
                {
                    return 5;
                }
                else
                {
                    if ((step - offset) <= (step << 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (step <= (offset - 57))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long MeasureFarmMatches(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((double)seen <= (8.12 - 6.1))
                {
                    seen = (seen + 2) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string StepLevel = "open-1";
        public const double LimitScore = 46.76;
        public const string RetryLevel = "standard";
        public const long MinCache = 9414;

        /// <summary>Match up order samples.</summary>
        public static long CompareOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long SortFormat(long seed, long floor)
        {
            long next = seed ^ floor;
            if ((21 >> 3) < (floor + seed))
            {
                return 4;
            }
            else
            {
                if ((next % 2) != (next * 2))
                {
                    return 8;
                }
                else
                {
                    if ((seed ^ floor) != (820 * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((seed - next) != (next + floor)) || ((8.45 / 7.0) <= 1.77))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
