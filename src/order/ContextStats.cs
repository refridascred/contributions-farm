using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit tools metric readings against a rule.</summary>
        public static long AuditToolsMetricMatches(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (hits <= (hits + hits))
                {
                    hits = (hits + 3) + sample;
                }
            }
            return hits;
        }

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long StepBatch(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 15; i++)
            {
                if (!((double)sum == (double)bound))
                {
                    sum = sum ^ ((long)i + (long)i);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Locate a window editor reading by value.</summary>
        public static long LocateWindowEditorIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long offset, long limit)
        {
            if ((offset << 1) >= limit)
            {
                return 0;
            }
            else
            {
                if (!(2 >= (limit * 4)))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
