using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long bound, long seed)
        {
            long lane = bound + seed;
            if ((bound - seed) > (lane ^ seed))
            {
                return 1;
            }
            else
            {
                if (!((double)bound >= (6.0 - 1.9)))
                {
                    return 6;
                }
                else
                {
                    if (((double)seed <= (5.0 / 2.0)) && (lane < (lane & 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound <= 97)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next buffer session value.</summary>
        public static double AdjustBufferSession(double weight, double bias)
        {
            double mean = 14.0 + (8.4 / 2.0);
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (bias - bias)) + (double)(long)i;
            }
            return mean + (4.9 - weight);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool ValidateReportLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Match up metrics notes samples.</summary>
        public static long OverlapMetricsNotesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit batch filter readings against a rule.</summary>
        public static long MeasureBatchFilterHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((4.0 + 5.0) != (double)count)
                {
                    count = (count + 3) + cell;
                }
            }
            return count;
        }
    }
}
