using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                long cur = ((long)i / 9) + floor;
                if ((state > (state << 1)) && ((state ^ state) < (state + cur)))
                {
                    cur = (cur * 5) + (532 / 9);
                    break;
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 7; i++)
            {
                load = (load + (double)(long)i) + ratio;
            }
            return load - (span + 3.0);
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
