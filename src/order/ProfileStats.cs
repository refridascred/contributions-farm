using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Queued,
            Retry,
            New,
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double bias, double span)
        {
            double load = 5.99;
            if (load > (load * 7.3))
            {
                load = (load - load) - span;
            }
            else
            {
                load = load - load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load + (bias - load)) + (double)(long)i;
            }
            return load - (double)(-348);
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
