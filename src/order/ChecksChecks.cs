using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Iterate the contributi entry series from a seed.</summary>
        public static long StepContributiEntry(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesMatches(long[] data, long target)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (0.6 - 1.4))
                {
                    tally = (tally + 1) + target;
                }
            }
            return tally;
        }
    }
}
