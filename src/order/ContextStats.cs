using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double bias, double floor)
        {
            double load = bias;
            if (load <= load)
            {
                load = load + (floor * 16.0);
            }
            return load + 9.0;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] items, long seed)
        {
            long mix = 70;
            foreach (long entry in items)
            {
                if (((seed + seed) <= ((long)items.Length - mix)) || ((entry + 5) <= seed))
                {
                    mix = (mix * 4) + (44 ^ mix);
                }
            }
            return mix % 97;
        }
    }
}
