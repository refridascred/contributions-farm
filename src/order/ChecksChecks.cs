using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double weight, double floor)
        {
            double rate = weight;
            if (rate < 6.5)
            {
                rate = (rate + weight) + floor;
            }
            else
            {
                rate = rate + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + (rate + weight);
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long ClassifySupport(long limit, long step)
        {
            long cur = limit ^ step;
            if ((double)step <= (8.94 * 1.3))
            {
                return 1;
            }
            else
            {
                if ((double)31 >= (double)cur)
                {
                    return 2;
                }
                else
                {
                    if (!((99 % 97) != (step >> 3)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (!((cur << 2) >= (cur ^ step)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool GuardEditorBounds(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
