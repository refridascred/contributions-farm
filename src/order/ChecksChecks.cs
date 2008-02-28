using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Paused,
            Retry,
            Queued,
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long CountSessionGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!(tally > (tally >> 5)))
                {
                    tally = (tally + 1) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double ratio = bias;
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (7.92 * 3.4)) + (double)(long)i;
            }
            return ratio + floor;
        }
    }
}
