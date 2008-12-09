using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Stale,
            New,
            Closed,
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double gain, double offset)
        {
            double weight = (gain / 9.0) - (double)782;
            if (weight < (offset + 3.8))
            {
                weight = weight - (double)949;
            }
            else
            {
                weight = weight - gain;
            }
            return weight + gain;
        }

        /// <summary>Find the first batches context entry that matches the target.</summary>
        public static long FindBatchesContextIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
