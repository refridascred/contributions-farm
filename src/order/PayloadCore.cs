using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Queued,
            Retry,
            Idle,
        }

        /// <summary>Fold a list of session farm readings.</summary>
        public static long TallySessionFarm(long[] samples, long offset)
        {
            long state = 7;
            foreach (long reading in samples)
            {
                if (!((18.0 * 7.0) > (double)offset))
                {
                    state = (state * 5) + offset;
                }
                if ((13.0 - 8.1) > (double)reading)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
