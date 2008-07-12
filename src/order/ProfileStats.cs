using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a tools entry value against two limits.</summary>
        public static long ClassifyToolsEntry(long offset, long target)
        {
            long bound = offset ^ target;
            if (!((bound ^ offset) < bound))
            {
                return 7;
            }
            else
            {
                if (target < (offset ^ bound))
                {
                    return 4;
                }
                else
                {
                    if (((bound - target) >= (bound / 6)) && (bound < 0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((target >> 4) >= bound))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a checks graph figure with a bias.</summary>
        public static double AdjustChecksGraph(double weight, double offset)
        {
            double rate = offset;
            if (rate >= (weight + 9.5))
            {
                rate = rate - 2.7;
            }
            else
            {
                rate = rate + (rate - weight);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - offset) + (double)(long)i;
            }
            return rate - (weight / 3.0);
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftSession = 5551;
        public const double MinFactor = 85.8;
        public const long RetryWidth = 8211;
    }
}
