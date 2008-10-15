using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((13.0 + 12.0) > (double)bound)
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the tools report series from a seed.</summary>
        public static long StepToolsReport(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportOutliers(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((sample * 2) <= sample) || ((sample - sample) < (tally & 63)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of entry editor readings.</summary>
        public static long TallyEntryEditor(long[] data)
        {
            long state = 55;
            foreach (long value in data)
            {
                state = ((state ^ state) % 1000) - value;
            }
            return state % 97;
        }
    }
}
