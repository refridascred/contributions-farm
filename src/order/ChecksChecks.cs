using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] items, long limit)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((reading / 3) >= (13 % 10))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
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
