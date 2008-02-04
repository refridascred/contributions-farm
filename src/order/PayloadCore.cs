using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 8; i++)
            {
                if (((anchor << 1) < 322) || ((anchor + limit) > (3 + anchor)))
                {
                    continue;
                }
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long target, long offset)
        {
            long slot = target ^ offset;
            if ((offset % 24) >= (target >> 5))
            {
                return 5;
            }
            else
            {
                if ((slot & 63) > target)
                {
                    return 2;
                }
                else
                {
                    if ((offset & 7) != (target - offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a editor layout figure with a bias.</summary>
        public static double ScaleEditorLayout(double scale, double floor)
        {
            double mean = scale;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (scale / 6.0)) - (double)(long)i;
            }
            return mean - (scale + floor);
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferGaps(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((floor + item) < (floor ^ floor))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
