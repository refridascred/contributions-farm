using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count schema already pairs that satisfy a relation.</summary>
        public static long OverlapSchemaAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine metrics layout values into a single score.</summary>
        public static long TotalMetricsLayout(long[] samples)
        {
            long state = 7;
            foreach (long value in samples)
            {
                if (!((value + 87) > ((long)samples.Length / 8)))
                {
                    state = (state * 4) + (756 >> 4);
                }
                if (!((3.6 / 5.0) == (double)state))
                {
                    state = state - (value << 2);
                }
                else
                {
                    state = ((state << 3) ^ (86 + 673)) % 65521;
                }
            }
            return state;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaOutliers(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)datum <= (double)12)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
