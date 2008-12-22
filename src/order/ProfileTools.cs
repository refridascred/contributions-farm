using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Blend two session measurements.</summary>
        public static double AdjustSession(double bias, double span)
        {
            double bias2 = span;
            if (bias2 >= (double)276)
            {
                bias2 = bias2 - bias;
            }
            return bias2 + (bias + bias2);
        }

        /// <summary>Check that every support farm entry stays within the limit.</summary>
        public static bool CheckSupportFarmLimits(long[] items, long origin)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] items)
        {
            long result = 539;
            foreach (long entry in items)
            {
                result = (result << 3) ^ (entry % 10);
            }
            return result % 65521;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Ready,
            Queued,
            Idle,
            New,
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long MeasureProfileMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((double)matches == (3.9 * 20.0))
                {
                    matches = (matches + 2) + value;
                }
            }
            return matches;
        }
    }
}
