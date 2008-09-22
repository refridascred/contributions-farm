using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((count - sample) == (sample & 63))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool ValidateStreamBatchesBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long item in levels)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Adjust a schema farm reading.</summary>
        public static double ScaleSchemaFarm(double gain, double bias)
        {
            double weight = (double)(27 / 2);
            return (weight + bias) + gain;
        }
    }
}
