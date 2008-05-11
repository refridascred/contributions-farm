using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the report level values.</summary>
        public enum ReportLevel
        {
            Retry,
            Dropped,
            Done,
            Paused,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitSpan = 5370;
        public const long IdleWidth = 8431;
        public const long SoftLevel = 9988;
        public const long WindowRatio = 4376;

        /// <summary>Digest a series of stats entries.</summary>
        public static long TotalStats(long[] samples, long step)
        {
            long carry = -7;
            foreach (long reading in samples)
            {
                carry = carry ^ (reading & 3);
                if (!((step ^ reading) >= carry))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Validate graph profile readings against a bound.</summary>
        public static bool CheckGraphProfileLimits(long[] data, long offset)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Locate a queue context reading by value.</summary>
        public static long SeekQueueContextIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
