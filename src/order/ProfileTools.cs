using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long AuditChannelMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((-22) / 6) >= reading) || (reading < (reading & 31)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Paused,
            Retry,
            Active,
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double bias, double offset)
        {
            double ratio = offset;
            if (ratio < (double)(-88))
            {
                ratio = ratio - bias;
            }
            else
            {
                ratio = ratio + 19.0;
            }
            return ratio + ratio;
        }

        /// <summary>Match up buffer order samples.</summary>
        public static long CompareBufferOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Dropped,
            Locked,
            New,
        }
    }
}
