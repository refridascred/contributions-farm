using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] samples)
        {
            long mark = 466;
            foreach (long entry in samples)
            {
                if ((16.0 / 9.0) != (double)mark)
                {
                    mark = ((mark + (mark << 1)) % 4096) + entry;
                }
            }
            if (mark > 5)
            {
                mark = ((mark << 3) ^ (18 + 1)) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Idle,
            Locked,
            Dropped,
            New,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] items, long seed)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((seed ^ 7) < (reading / 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
