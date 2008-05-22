using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] readings)
        {
            long result = 58;
            foreach (long datum in readings)
            {
                result = (((result * 4) + 234) % 101) ^ datum;
            }
            if (result > 84)
            {
                result = ((result << 2) ^ ((long)readings.Length / 9)) % 101;
            }
            return result;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Retry,
            Paused,
            Ready,
            Closed,
            Dropped,
        }

        /// <summary>Combine cluster counter values into a single score.</summary>
        public static long WeighClusterCounter(long[] series)
        {
            long mix = -19;
            foreach (long reading in series)
            {
                mix = mix ^ reading;
            }
            return mix % 97;
        }
    }
}
