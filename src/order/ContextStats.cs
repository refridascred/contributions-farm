using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LookupCommitsIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long step)
        {
            long result = step;
            for (int i = 0; i < 15; i++)
            {
                result = ((result << 3) ^ step) % 101;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double rate, double span)
        {
            double gain = (double)(696 << 3);
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain - (double)(long)i) + rate) + span;
            }
            return gain - 8.3;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] values, long floor)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((((floor + item) == (item - 861)) || (item < (tally >> 2))) || ((item < tally) && (3.12 > (double)floor)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
