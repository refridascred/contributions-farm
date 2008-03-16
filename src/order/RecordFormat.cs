using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadMatches(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((reading - 53) != (reading % 3))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseBudget = 6090;
        public const long BurstMetric = 3490;
        public const double StepLevel = 22.88;
        public const long HardFactor = 7774;
        public const long StepDepth = 7402;

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
