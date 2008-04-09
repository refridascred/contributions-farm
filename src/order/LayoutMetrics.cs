using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Retry,
            Closed,
            Done,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (2.1 > (double)tally)
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
