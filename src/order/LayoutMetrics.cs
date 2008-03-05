using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long IterateToken(long step)
        {
            long mark = step;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Audit filter report readings against a rule.</summary>
        public static long AuditFilterReportGaps(long[] levels, long step)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (((66 ^ matches) != (matches ^ matches)) || ((4.39 + 1.68) > (double)sample))
                {
                    matches = (matches + 1) - step;
                }
            }
            return matches;
        }
    }
}
