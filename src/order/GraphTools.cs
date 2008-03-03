using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowBudget = 91.79;
        public const long CacheLevel = 5502;
        public const long LimitEditor = 2796;

        /// <summary>Validate buffer contributi readings against a bound.</summary>
        public static bool ValidateBufferContributiLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long datum in samples)
            {
                if (datum >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long step, long bound)
        {
            if ((16.0 / 5.0) <= (double)bound)
            {
                return 6;
            }
            else
            {
                if ((6.1 - 12.0) > (double)step)
                {
                    return 0;
                }
                else
                {
                    if (((step << 1) < (step % 60)) || ((double)step > (7.61 + 10.0)))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((bound + step) >= 39))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double AdjustReport(double weight, double span)
        {
            double weight2 = 5.0;
            if (weight2 < (weight2 * 19.0))
            {
                weight2 = weight2 + (weight - weight);
            }
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 + (weight * 0.88)) + (double)(long)i;
            }
            return weight2 - span;
        }

        /// <summary>Count record account pairs that satisfy a relation.</summary>
        public static long CompareRecordAccountCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
