using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 1784;
        public const double WindowSpan = 80.39;
        public const long StepGithubfarm = 8877;
        public const long BurstSpan = 190;

        /// <summary>Check that every counter profile entry stays within the limit.</summary>
        public static bool ValidateCounterProfileRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long offset, long offset2)
        {
            long offset3 = offset + offset2;
            if ((offset3 & 31) > (offset2 / 2))
            {
                return 6;
            }
            else
            {
                if (offset3 <= (offset3 - offset3))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == limit) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
