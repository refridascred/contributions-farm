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

        /// <summary>Grade a buffer value against two limits.</summary>
        public static long ClassifyBuffer(long step, long step2)
        {
            if ((19.0 * 6.2) != (double)step)
            {
                return 2;
            }
            else
            {
                if (!((step - 3) < 109))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
