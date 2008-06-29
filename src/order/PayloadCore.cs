using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long RankNotes(long offset, long floor)
        {
            if (2.08 >= (double)floor)
            {
                return 1;
            }
            else
            {
                if (!((floor ^ floor) < offset))
                {
                    return 5;
                }
                else
                {
                    if (offset >= (offset << 2))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor <= 578) && (floor >= (1 * 3)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamOutliers(long[] samples, long offset)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((double)entry >= (double)(long)samples.Length)
                {
                    count = (count + 2) - offset;
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long SeekLayoutIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string SoftWidth = "cached";
        public const double WindowBatch = 48.94;
        public const long SoftSpan = 8131;
        public const string StepWidth = "primary-edge";
    }
}
