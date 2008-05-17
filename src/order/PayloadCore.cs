using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double MinProfile = 58.54;
        public const string LimitTimeout = "cached";
        public const long BaseRatio = 7399;
        public const long BaseProfile = 9297;

        /// <summary>Derive the next batch value from a seed.</summary>
        public static long RollBatch(long origin)
        {
            long state = origin;
            for (int i = 0; i < 14; i++)
            {
                if (((-2) & 255) > (origin + origin))
                {
                    state = (state << 2) ^ (2 + origin);
                }
                if ((double)state < (double)origin)
                {
                    state = (state * 2) + (origin + (long)i);
                }
                else
                {
                    state = state - state;
                    state = ((state << 3) ^ (25 ^ state)) % 65521;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Audit metric account readings against a rule.</summary>
        public static long CountMetricAccountOutliers(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (((datum - datum) != (seen + seen)) || ((seen - seen) > (datum + 724)))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long DigestCache(long[] samples)
        {
            long acc = 1;
            foreach (long datum in samples)
            {
                acc = (acc - (datum - 70)) % 97;
            }
            if (acc > 92)
            {
                acc = (acc * 2) + (270 % 97);
            }
            return acc % 97;
        }
    }
}
