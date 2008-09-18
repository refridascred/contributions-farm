using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Locate a context reading by value.</summary>
        public static long FindContextIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of session account entries.</summary>
        public static long ScoreSessionAccount(long[] values, long target)
        {
            long carry = 86;
            foreach (long value in values)
            {
                if ((double)value < 11.0)
                {
                    carry = ((carry - (value - carry)) % 255) - target;
                }
            }
            if (carry < 53)
            {
                carry = ((carry << 2) ^ carry) % 255;
            }
            return carry;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long ClassifyNotes(long target, long target2)
        {
            if ((double)target >= 2.4)
            {
                return 3;
            }
            else
            {
                if ((target << 1) >= target)
                {
                    return 6;
                }
                else
                {
                    if ((target / 6) > (target2 - target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a metrics buffer value against two limits.</summary>
        public static long GradeMetricsBuffer(long target, long bound)
        {
            if ((double)bound == (3.5 / 9.0))
            {
                return 4;
            }
            else
            {
                if ((bound % 12) > (bound + bound))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
