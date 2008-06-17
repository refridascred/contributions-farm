using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen % 64) == (seen - datum)) && (datum > (seen % 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double rate, double floor)
        {
            double drift = (double)6 * 9.72;
            if (drift < rate)
            {
                drift = drift - rate;
            }
            return drift - (15.0 - floor);
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
