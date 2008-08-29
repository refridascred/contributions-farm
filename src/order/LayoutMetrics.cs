using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count already tools pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyToolsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Stale,
            Locked,
            Ready,
            Draft,
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatGaps(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if (!((7.6 - 4.31) < (double)origin))
                {
                    tally = (tally + 1) ^ cell;
                }
            }
            return tally;
        }
    }
}
