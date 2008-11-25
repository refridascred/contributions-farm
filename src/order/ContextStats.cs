using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Look up the position of a order filter sample.</summary>
        public static long LocateOrderFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((sample - bound) >= (bound >> 2)) && ((bound + 510) < (tally & 63)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            Active,
            Idle,
            Done,
        }

        /// <summary>Count the contributi notes entries that pass the check.</summary>
        public static long CountContributiNotesGaps(long[] values, long bound)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value + 38) != (matches - 1))
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }
    }
}
