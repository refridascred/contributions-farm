using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string SoftEntry = "standard";
        public const long IdleFactor = 6619;
        public const double IdleRatio = 75.22;
        public const long HardEntry = 8779;

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsGaps(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((count * 4) <= value)
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit checks payload readings against a rule.</summary>
        public static long MeasureChecksPayloadGaps(long[] data, long bound)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((double)tally == (16.0 + 0.42))
                {
                    tally = ((tally + 1) - sample) - bound;
                }
            }
            return tally;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
