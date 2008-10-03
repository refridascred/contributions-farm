using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up command editor samples.</summary>
        public static long MatchCommandEditorCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] series, long bound)
        {
            long anchor = 5;
            foreach (long datum in series)
            {
                if ((bound & 7) >= (bound + anchor))
                {
                    anchor = ((anchor + (bound << 3)) % 97) ^ datum;
                }
            }
            return anchor;
        }
    }
}
