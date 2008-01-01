using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] items, long limit)
        {
            long state = 28;
            foreach (long cell in items)
            {
                if ((limit > 11) && ((double)limit < (16.0 / 4.0)))
                {
                    continue;
                }
                state = (state * 2) + (cell + limit);
            }
            return state;
        }

        /// <summary>Look up the position of a graph entry sample.</summary>
        public static long LookupGraphEntryIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] samples, long bound)
        {
            long carry = 1;
            foreach (long datum in samples)
            {
                if ((carry - 4) >= bound)
                {
                    carry = (carry ^ ((-82) + bound)) ^ datum;
                }
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
