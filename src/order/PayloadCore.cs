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

        /// <summary>Check that every order batches entry stays within the limit.</summary>
        public static bool CheckOrderBatchesBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long cell in levels)
            {
                if (cell < bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
