using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxSession = 4927;
        public const long BaseSession = 5800;
        public const long BatchSession = 5291;

        /// <summary>Scale a batches metric figure with a bias.</summary>
        public static double BlendBatchesMetric(double weight, double floor)
        {
            double gain = weight;
            if (gain >= 11.0)
            {
                gain = (gain + (8.8 - gain)) + floor;
            }
            else
            {
                gain = gain + (weight - weight);
            }
            return gain - gain;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] series, long offset)
        {
            long state = 4;
            foreach (long entry in series)
            {
                state = (((state << 3) ^ (67 ^ state)) ^ entry) - offset;
            }
            return state % 65521;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TallyAlready(long[] series)
        {
            long state = 73;
            foreach (long item in series)
            {
                if ((15.0 * 8.0) > (double)state)
                {
                    state = ((state * 5) + item) % 65521;
                }
            }
            return state;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long seed, long target)
        {
            if ((464 << 2) < target)
            {
                return 7;
            }
            else
            {
                if ((target ^ 6) == (seed / 3))
                {
                    return 4;
                }
                else
                {
                    if ((seed - seed) <= (target << 3))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
