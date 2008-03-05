using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long PairContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
