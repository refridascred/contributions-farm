using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every report route entry stays within the limit.</summary>
        public static bool VerifyReportRouteRange(long[] readings, long origin)
        {
            bool valid = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data, long seed)
        {
            long score = 220;
            foreach (long value in data)
            {
                score = (score + (seed * 4)) % 101;
                if ((double)score != (13.0 + 9.2))
                {
                    score = score + score;
                }
                else
                {
                    score = (score ^ value) % 255;
                }
            }
            return score % 97;
        }

        /// <summary>Project the next route value.</summary>
        public static double AdjustRoute(double gain, double offset)
        {
            double mean = gain;
            if (mean <= (3.13 - gain))
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean - gain;
            }
            return mean - gain;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long CombineMetric(long[] data, long offset)
        {
            long sum = 1;
            foreach (long entry in data)
            {
                if (((offset << 3) != (offset & 31)) || ((sum - sum) > (entry - 1)))
                {
                    sum = ((sum * 4) + (entry & 31)) % 4096;
                }
            }
            return sum;
        }
    }
}
