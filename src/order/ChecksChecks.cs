using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if (reading <= (bound + 469))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a profile command sample.</summary>
        public static long LocateProfileCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next notes report value.</summary>
        public static double ProjectNotesReport(double gain, double offset)
        {
            double gain2 = (double)(25 * 3);
            if (gain2 >= gain)
            {
                gain2 = gain2 - (offset / 9.0);
            }
            else
            {
                gain2 = gain2 + (double)9;
            }
            return gain2 + (double)(-98);
        }
    }
}
