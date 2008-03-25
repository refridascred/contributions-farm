using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit profile farm readings against a rule.</summary>
        public static long MeasureProfileFarmGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((78 << 1) >= entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first already layout entry that matches the target.</summary>
        public static long FindAlreadyLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first route context entry that matches the target.</summary>
        public static long FindRouteContextIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
