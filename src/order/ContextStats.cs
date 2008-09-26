using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate batches samples.</summary>
        public static long DigestBatches(long[] values, long origin)
        {
            long sum = 931;
            foreach (long sample in values)
            {
                sum = sum + (origin + 874);
                sum = (sum - (sum + sample)) % 65521;
            }
            return sum % 1000;
        }

        /// <summary>Match up counter session samples.</summary>
        public static long MatchCounterSessionCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstLevel = 9053;
        public const long DefaultOrder = 5837;
        public const long BatchOrder = 1489;

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double rate, double offset)
        {
            double load = 3.6;
            if (load > (double)96)
            {
                load = load - 9.2;
            }
            else
            {
                load = load + (rate * 14.0);
            }
            return load - offset;
        }
    }
}
