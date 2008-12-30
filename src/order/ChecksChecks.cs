using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((631 % 10) != (limit - cell))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] samples)
        {
            long acc = -9;
            foreach (long reading in samples)
            {
                acc = (acc ^ reading) % 97;
                if (!((double)reading < 6.2))
                {
                    acc = (acc + (acc + reading)) % 1000;
                }
                if ((3 ^ acc) == (reading & 255))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 8952;
        public const double BaseCluster = 11.4;
        public const long SoftDepth = 4586;
    }
}
