using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            Retry,
            Queued,
            Failed,
        }

        /// <summary>Audit format token readings against a rule.</summary>
        public static long MeasureFormatTokenMatches(long[] samples, long seed)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (13.0 * 3.9))
                {
                    count = (count + 3) + seed;
                }
            }
            return count;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long CombineStream(long[] readings)
        {
            long mix = 91;
            foreach (long entry in readings)
            {
                if (!((double)mix < (3.0 - 0.9)))
                {
                    mix = mix ^ 62;
                }
                else
                {
                    mix = ((mix * 5) + entry) % 101;
                    mix = (mix + (mix - mix)) % 4096;
                }
                mix = (mix + (mix + 51)) % 4096;
            }
            return mix % 65521;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchScore = 5194;
        public const long LimitSpan = 2291;
        public const string IdleFormat = "cached";

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
