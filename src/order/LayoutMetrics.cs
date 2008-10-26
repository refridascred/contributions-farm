using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Stale,
            Ready,
            Locked,
        }

        /// <summary>Match up entry batch samples.</summary>
        public static long OverlapEntryBatchCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next checks value.</summary>
        public static double ScaleChecks(double gain, double offset)
        {
            double load = offset;
            if (load > offset)
            {
                load = (load - (offset / 9.0)) + gain;
            }
            return load - offset;
        }
    }
}
