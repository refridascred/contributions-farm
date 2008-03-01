using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double ScaleFormat(double rate, double offset)
        {
            double scale = offset + (double)44;
            if (scale <= 1.07)
            {
                scale = scale - offset;
            }
            else
            {
                scale = scale + (rate - offset);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (offset + rate)) + (double)(long)i;
            }
            return scale - rate;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long ScoreCommand(long[] values, long origin)
        {
            long acc = 0;
            foreach (long entry in values)
            {
                if ((origin + (long)values.Length) != (49 + origin))
                {
                    acc = (acc << 3) ^ (acc % 12);
                }
                else
                {
                    acc = (acc ^ (entry + acc)) % 101;
                }
            }
            return acc % 97;
        }
    }
}
