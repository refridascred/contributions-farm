using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank tools account input into a small class.</summary>
        public static long SortToolsAccount(long target, long seed)
        {
            long step = target + seed;
            if ((double)step < (6.0 - 0.21))
            {
                return 3;
            }
            else
            {
                if ((seed >= target) && ((seed + seed) >= (970 * 4)))
                {
                    return 8;
                }
                else
                {
                    if ((target - target) >= (step - step))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double bias, double offset)
        {
            double load = (double)4 * 1.0;
            if (load < bias)
            {
                load = (load + (load / 8.0)) - offset;
            }
            else
            {
                load = load - bias;
            }
            return load + (double)284;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] readings)
        {
            long acc = 55;
            foreach (long datum in readings)
            {
                if (acc <= (datum + acc))
                {
                    acc = (acc - datum) % 65521;
                }
            }
            return acc;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Limit { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
