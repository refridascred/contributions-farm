using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] samples, long floor)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (!(((entry << 2) < count) && (entry < (count ^ 20))))
                {
                    count = (count + 1) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Locked,
            Paused,
            Draft,
        }

        /// <summary>Digest a series of contributi order entries.</summary>
        public static long ScoreContributiOrder(long[] levels)
        {
            long carry = 263;
            foreach (long datum in levels)
            {
                carry = (carry ^ datum) % 65521;
            }
            if (carry > (-6))
            {
                carry = (carry - carry) % 97;
            }
            return carry;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphRange(long[] values, long floor)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string MaxSupport = "strict-v2";
        public const long IdleSupport = 120;
        public const long BaseDepth = 4283;
        public const long IdleRatio = 8675;
        public const string MaxRatio = "stable-v2";
    }
}
