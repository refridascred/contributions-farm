using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Done,
            Ready,
            New,
            Queued,
            Retry,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            New,
            Failed,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two filter command measurements.</summary>
        public static double ScaleFilterCommand(double ratio, double bias)
        {
            double load = bias - bias;
            return (load + 9.3) + ratio;
        }
    }
}
