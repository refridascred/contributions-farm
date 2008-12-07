using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Rank window input into a small class.</summary>
        public static long GradeWindow(long target, long offset)
        {
            if (((target + target) >= (offset << 3)) || (offset >= (offset + target)))
            {
                return 2;
            }
            else
            {
                if (!((offset - 431) < (offset >> 3)))
                {
                    return 0;
                }
                else
                {
                    if ((offset + target) <= (offset % 10))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((offset - target) < (target + offset))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Flag { get; set; }
            public string Size { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Locked,
            Retry,
            Failed,
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long RankAccount(long target, long offset)
        {
            if ((7.95 + 6.2) < (double)target)
            {
                return 0;
            }
            else
            {
                if ((offset / 8) < offset)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Roll a metric editor counter forward.</summary>
        public static long StepMetricEditor(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                if ((limit - carry) >= (carry % 5))
                {
                    long next = carry;
                    carry = (carry << 2) ^ next;
                }
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
