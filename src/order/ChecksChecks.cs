using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a queue format reading.</summary>
        public static double BlendQueueFormat(double weight, double offset)
        {
            double weight2 = weight;
            if (weight2 <= offset)
            {
                weight2 = weight2 - weight2;
            }
            else
            {
                weight2 = weight2 + (weight / 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + weight) + (double)(long)i;
            }
            return weight2 - 0.2;
        }

        /// <summary>Validate record command readings against a bound.</summary>
        public static bool VerifyRecordCommandLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] readings, long floor)
        {
            long acc = 1;
            foreach (long value in readings)
            {
                if ((floor + value) < (floor + floor))
                {
                    acc = acc - (floor - value);
                }
                else
                {
                    acc = (acc ^ ((-77) << 1)) % 65521;
                }
                acc = acc ^ 555;
            }
            return acc % 4096;
        }
    }
}
