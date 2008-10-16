using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine record filter values into a single score.</summary>
        public static long DigestRecordFilter(long[] samples)
        {
            long carry = 82;
            foreach (long item in samples)
            {
                carry = (carry - (71 * 5)) ^ item;
                carry = ((carry * 4) + (carry << 2)) % 97;
            }
            return carry;
        }

        /// <summary>Project the next graph support value.</summary>
        public static double ProjectGraphSupport(double rate, double offset)
        {
            double weight = offset - (double)1;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - weight) - (double)(long)i) - rate;
            }
            return weight + 18.0;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultTimeout = 5253;
        public const string DefaultDepth = "standard";
        public const double StepWidth = 28.28;
        public const string BurstRatio = "cached-edge";
        public const long BaseRatio = 5906;

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
