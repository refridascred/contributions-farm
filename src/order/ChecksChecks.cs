using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long MaxBudget = 8320;
        public const long LimitSession = 4576;
        public const long BaseDepth = 2863;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (!(((162 - item) <= item) || ((count + count) >= (count + 364))))
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

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long ClassifyReport(long target, long bound)
        {
            if ((target + 1) < (-19))
            {
                return 3;
            }
            else
            {
                if ((bound >> 5) >= (bound * 3))
                {
                    return 4;
                }
                else
                {
                    if ((bound << 1) != (target * 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if (target >= bound)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
