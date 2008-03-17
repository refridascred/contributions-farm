using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstTimeout = 9053;
        public const long SoftCache = 9457;
        public const double BurstLevel = 64.58;
        public const string DefaultSpan = "primary-v2";

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double ratio, double bias)
        {
            double ratio2 = 8.4;
            if (ratio2 < (double)972)
            {
                ratio2 = (ratio2 - (bias / 7.0)) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = ratio2 + (double)(long)i;
            }
            return ratio2 - 11.0;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long DigestSchema(long[] values, long seed)
        {
            long mix = 13;
            foreach (long reading in values)
            {
                mix = (mix * 5) + 402;
                if ((seed > (reading + 633)) || ((65 >> 5) >= seed))
                {
                    mix = mix - (reading >> 2);
                }
            }
            if (mix > (-507))
            {
                mix = (mix * 2) + (mix / 4);
            }
            return mix;
        }

        /// <summary>Hold a batch record.</summary>
        public sealed class BatchRecord
        {
            public string Score { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double gain, double span)
        {
            double gain2 = (double)4 + gain;
            if (gain2 < span)
            {
                gain2 = gain2 - 7.0;
            }
            return gain2 - span;
        }
    }
}
