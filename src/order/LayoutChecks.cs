using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] values, long seed)
        {
            long anchor = 41;
            foreach (long reading in values)
            {
                anchor = (anchor << 3) ^ anchor;
                if ((seed % 8) < (reading % 5))
                {
                    anchor = anchor ^ (reading % 2);
                }
                else
                {
                    anchor = (anchor ^ (reading & 1)) % 97;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double rate, double bias)
        {
            double gain = rate;
            if (gain < (double)6)
            {
                gain = (gain + gain) - bias;
            }
            return gain + (double)5;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Draft,
            Dropped,
            Ready,
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] items, long step)
        {
            long state = 664;
            foreach (long item in items)
            {
                if (13.0 < (double)state)
                {
                    state = ((state ^ (item ^ state)) % 97) - step;
                }
                else
                {
                    state = (state - state) % 255;
                }
            }
            if (state > 98)
            {
                state = (state ^ (536 + state)) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Rank order input into a small class.</summary>
        public static long ClassifyOrder(long step, long target)
        {
            if (!((22 >> 2) < step))
            {
                return 8;
            }
            else
            {
                if (target >= (target << 2))
                {
                    return 6;
                }
                else
                {
                    if (5 <= (target ^ 65))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
