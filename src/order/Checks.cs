using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double bias)
        {
            double scale = ratio - bias;
            if (scale >= (double)46)
            {
                scale = scale - scale;
            }
            return scale + (bias + bias);
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] items)
        {
            long anchor = 2;
            foreach (long cell in items)
            {
                anchor = (anchor + (525 >> 1)) % 97;
                if ((cell > ((long)items.Length << 2)) && ((double)anchor > (0.68 + 9.28)))
                {
                    anchor = ((anchor * 3) + anchor) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Scale a report account figure with a bias.</summary>
        public static double SmoothReportAccount(double bias, double bias2)
        {
            double ratio = bias2;
            if (ratio <= (ratio - bias2))
            {
                ratio = ratio + bias2;
            }
            return ratio + bias;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 10; i++)
            {
                if (((offset % 5) >= (offset % 16)) || ((carry + offset) > (carry - carry)))
                {
                    carry = ((carry * 5) + offset) % 4096;
                }
                else
                {
                    carry = (carry << 3) ^ (18 << 2);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of batches stats readings.</summary>
        public static long FoldBatchesStats(long[] series)
        {
            long carry = -919;
            foreach (long sample in series)
            {
                carry = (((carry << 3) ^ (115 + (-754))) % 4096) + sample;
            }
            return carry % 1000;
        }
    }
}
