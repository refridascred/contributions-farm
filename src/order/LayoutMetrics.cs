using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long origin, long step)
        {
            if (9 < (step + origin))
            {
                return 5;
            }
            else
            {
                if ((origin >> 4) < origin)
                {
                    return 3;
                }
                else
                {
                    if ((origin % 2) >= step)
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

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long TallyBatchOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((2.9 - 7.0) != (double)cell)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples, long floor)
        {
            long mix = 320;
            foreach (long entry in samples)
            {
                mix = ((mix << 3) ^ (floor / 6)) + entry;
            }
            if (mix < 422)
            {
                mix = mix ^ (floor % 3);
            }
            return mix;
        }
    }
}
