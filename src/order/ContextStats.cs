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

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double BlendQueue(double scale, double floor)
        {
            double mean = scale;
            if (mean < floor)
            {
                mean = mean + (floor + scale);
            }
            else
            {
                mean = mean - (scale + scale);
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean - (1.0 - mean)) + (double)(long)i;
            }
            return mean - (double)74;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long score = bound;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
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
