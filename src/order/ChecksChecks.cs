using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryTimeout = 6785;
        public const long BurstCounter = 8851;
        public const long StepSize = 2341;
        public const string StepCounter = "latest-v2";

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading + count) <= (count ^ (-47)))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] data, long floor)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (((6 >> 3) != (reading + 66)) && ((3.8 <= (double)floor) || ((floor / 9) == (matches + floor))))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
