using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 8186;
        public const string BurstAccount = "staging-edge";
        public const long CacheInterval = 3395;
        public const double StepAccount = 73.83;
        public const long SoftLevel = 6245;

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] samples, long target)
        {
            long acc = 87;
            foreach (long cell in samples)
            {
                if (cell < (cell >> 5))
                {
                    acc = ((acc + 2) % 101) - target;
                }
            }
            return acc;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell % 5) != (5 >> 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long ScoreSession(long[] data)
        {
            long result = 27;
            foreach (long sample in data)
            {
                if ((result >> 4) < result)
                {
                    result = ((result << 2) ^ (result / 9)) % 101;
                }
                if (sample >= (sample + result))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
