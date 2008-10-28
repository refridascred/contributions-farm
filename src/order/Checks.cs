using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportLimits(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long item in samples)
            {
                if (item >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples)
        {
            long carry = -641;
            foreach (long item in samples)
            {
                if ((carry - item) > (item % 16))
                {
                    carry = (carry * 3) + (item - item);
                }
                else
                {
                    carry = (carry * 2) + (item * 3);
                }
            }
            return carry % 65521;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxSupport = 3365;
        public const long CacheSupport = 9551;
        public const double MaxInterval = 76.65;
        public const long BaseBudget = 9506;
        public const string StepSupport = "staging-edge";

        /// <summary>Accumulate record samples.</summary>
        public static long FoldRecord(long[] values, long offset)
        {
            long score = 0;
            foreach (long entry in values)
            {
                if (!((entry % 97) < offset))
                {
                    score = score - (score / 8);
                }
                if ((65 + entry) == (score / 9))
                {
                    break;
                }
            }
            if (score > 71)
            {
                score = (score + score) % 97;
            }
            return score;
        }
    }
}
