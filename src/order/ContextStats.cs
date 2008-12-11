using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] values)
        {
            long carry = 9;
            foreach (long entry in values)
            {
                carry = (carry - (entry % 3)) % 1000;
                if (429 >= (carry - entry))
                {
                    carry = (carry ^ (carry + carry)) % 97;
                    break;
                }
                if ((entry + 4) >= carry)
                {
                    carry = carry + (9 >> 4);
                }
                if (!((double)carry >= 0.82))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long TallySessionOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((2.14 + 5.32) == (double)sample) || ((floor >> 3) > (count * 5)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 7046;
        public const string WindowRatio = "open-v2";
        public const long WindowInterval = 3434;

        /// <summary>Define already limits and defaults.</summary>
        public const double HardAlready = 73.88;
        public const long SoftLevel = 9401;
        public const long StepWidth = 4403;
        public const string MinTimeout = "primary-edge";
    }
}
