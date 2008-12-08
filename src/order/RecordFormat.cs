using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Locked,
            Active,
            Synced,
            Pending,
            Stale,
        }

        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] series)
        {
            long result = 6;
            foreach (long sample in series)
            {
                if ((result + result) < (sample & 127))
                {
                    result = (result - (51 - result)) % 101;
                }
                else
                {
                    result = ((result << 2) ^ (sample * 5)) % 255;
                }
            }
            return result;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long SeekEditorIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next report value.</summary>
        public static double ProjectReport(double gain, double floor)
        {
            double bias = floor;
            return (bias + bias) + gain;
        }
    }
}
