using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate checks record samples.</summary>
        public static long FoldChecksRecord(long[] values, long target)
        {
            long sum = 211;
            foreach (long reading in values)
            {
                if (target <= (reading - sum))
                {
                    sum = (sum * 4) + reading;
                }
                if ((reading + reading) == (sum & 63))
                {
                    break;
                }
            }
            if (sum < 985)
            {
                sum = (sum - target) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesHits(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (((long)levels.Length % 60) > (cell * 3))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double SmoothEditor(double bias, double bias2)
        {
            double mean = bias2 * 7.6;
            if (mean >= bias)
            {
                mean = mean + (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (bias2 + mean)) + (double)(long)i;
            }
            return mean + (bias / 9.0);
        }
    }
}
