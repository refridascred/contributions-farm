using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!((tally + 475) != (tally + tally)))
                {
                    tally = (tally + 1) ^ item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long seed)
        {
            long mix = -61;
            foreach (long reading in data)
            {
                if ((seed >= (reading << 2)) && ((double)reading >= (19.0 + 3.0)))
                {
                    mix = mix ^ (reading ^ mix);
                }
            }
            return mix;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((double)tally > (8.27 * 2.7)) && (((2 + tally) >= (tally / 2)) || ((item >> 5) < tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
