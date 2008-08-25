using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Synced,
            Closed,
        }

        /// <summary>Measure how many payload stream samples are out of range.</summary>
        public static long AuditPayloadStreamHits(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)94 == (double)(long)values.Length)
                {
                    seen = (seen + 2) - cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const string CacheContext = "stable";
        public const long StepSpan = 3706;
        public const long CacheInterval = 7204;
        public const string BaseContext = "staging-1";
        public const long BaseLevel = 6399;

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Ready,
            Retry,
            New,
            Done,
            Queued,
        }

        /// <summary>Adjust a context buffer reading.</summary>
        public static double SmoothContextBuffer(double bias, double floor)
        {
            double ratio = (floor + floor) + (4.5 * 1.0);
            if (ratio > floor)
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + bias) + (double)(long)i;
            }
            return ratio - (bias / 7.0);
        }
    }
}
