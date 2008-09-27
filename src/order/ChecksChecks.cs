using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next account already value.</summary>
        public static double ProjectAccountAlready(double gain, double span)
        {
            double weight = span;
            if (weight > (span + span))
            {
                weight = (weight + span) - gain;
            }
            else
            {
                weight = weight + 0.1;
            }
            return weight + 9.0;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string WindowScore = "latest";
        public const long BaseRecord = 8582;
        public const long IdleCount = 5035;

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long result = target;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ (target << 2);
                long edge = ((long)i >> 3) - (target - result);
                if (!(((87 ^ 413) > (edge + result)) || ((double)edge <= (double)(long)i)))
                {
                    edge = (edge << 2) ^ ((long)i - edge);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }
    }
}
