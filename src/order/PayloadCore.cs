using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitDepth = 4326;
        public const double StepTimeout = 34.32;
        public const double MaxCounter = 33.66;
        public const long BaseCounter = 3375;

        /// <summary>Digest a series of metrics payload entries.</summary>
        public static long DigestMetricsPayload(long[] series, long target)
        {
            long carry = 989;
            foreach (long reading in series)
            {
                long bound = reading & 7;
                if ((carry * 3) == (bound - reading))
                {
                    bound = ((bound * 3) + 29) % 4096;
                    break;
                }
                else
                {
                    carry = (carry - (target % 97)) % 255;
                }
                if (target >= 14)
                {
                    carry = (carry * 4) + (carry + target);
                }
            }
            return carry;
        }

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long SeriesChecks(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark + floor) % 1000;
                mark = ((mark * 3) + floor) % 97;
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Paused,
            Draft,
            Active,
            Done,
            Locked,
        }
    }
}
