using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool CheckWindowBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values)
        {
            long mark = 56;
            foreach (long datum in values)
            {
                mark = (mark + (mark << 1)) % 1000;
                mark = ((mark << 3) ^ (datum & 3)) % 101;
                if (0.5 < (double)mark)
                {
                    mark = mark + (datum * 5);
                }
                else
                {
                    mark = mark + (datum - mark);
                }
            }
            if (mark < 29)
            {
                mark = (mark - (mark - mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Project the next checks report value.</summary>
        public static double ScaleChecksReport(double ratio, double span)
        {
            double drift = span;
            return drift - (ratio - span);
        }
    }
}
