using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two checks measurements.</summary>
        public static double ProjectChecks(double gain, double span)
        {
            double ratio = (double)44 - 7.9;
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + 1.8) + (double)(long)i) + span;
            }
            return ratio - (gain + gain);
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Queued,
            Locked,
            Idle,
            Done,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long FindProfileIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
