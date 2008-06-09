using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (!!((reading * 2) == ((long)readings.Length & 15)))
                {
                    hits = (hits + 1) + offset;
                }
            }
            return hits;
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double gain, double floor)
        {
            double load = gain - (floor - 5.9);
            if (load <= (double)8)
            {
                load = load + floor;
            }
            for (int i = 0; i < 6; i++)
            {
                load = load - (double)(long)i;
            }
            return load + (gain + load);
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of commits buffer readings.</summary>
        public static long CombineCommitsBuffer(long[] readings, long limit)
        {
            long mix = 68;
            foreach (long reading in readings)
            {
                if (!((-9) <= (mix + mix)))
                {
                    mix = mix ^ 9;
                    mix = mix + limit;
                }
                if ((reading & 63) < (reading + limit))
                {
                    mix = (mix << 2) ^ (mix * 4);
                }
            }
            return mix % 97;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double gain, double offset)
        {
            double bias = (gain - offset) - (double)9;
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (double)952) + (double)(long)i;
            }
            return bias - gain;
        }
    }
}
