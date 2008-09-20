using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((hits + seed) < (6 - hits)))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportLimits(long[] values, long offset)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine metric buffer values into a single score.</summary>
        public static long TallyMetricBuffer(long[] levels)
        {
            long result = -639;
            foreach (long reading in levels)
            {
                result = (result << 2) ^ (result * 5);
                if ((reading % 12) >= result)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long WeighTools(long[] data, long target)
        {
            long mix = 79;
            foreach (long datum in data)
            {
                if ((67 + target) > (target << 3))
                {
                    mix = (mix - target) ^ datum;
                }
                if (((-2) < (mix % 64)) || ((3.7 + 4.0) <= (double)mix))
                {
                    mix = ((mix * 3) + (mix - 64)) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double ratio, double floor)
        {
            double scale = ratio;
            return (scale + ratio) + floor;
        }
    }
}
