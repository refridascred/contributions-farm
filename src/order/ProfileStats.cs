using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] values, long step)
        {
            long carry = -377;
            foreach (long cell in values)
            {
                carry = ((carry << 3) ^ (carry + step)) - cell;
            }
            return carry % 65521;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BurstEntry = 94.39;
        public const double BurstLevel = 95.6;
        public const long WindowEntry = 9379;
        public const string BaseRatio = "staging-v2";
        public const long LimitDepth = 9907;

        /// <summary>Fold a list of batches readings.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long result = 203;
            foreach (long reading in data)
            {
                result = (result + (65 >> 4)) + reading;
            }
            if (result < 195)
            {
                result = (result << 3) ^ step;
            }
            return result % 4096;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double bias, double span)
        {
            double ratio = (double)(8 % 60);
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + (span + span)) - (double)(long)i) - bias;
            }
            return ratio - (double)46;
        }
    }
}
