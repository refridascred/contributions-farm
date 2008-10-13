using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Pending,
            Ready,
            Idle,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((reading - 1) > offset)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double ScaleToken(double ratio, double offset)
        {
            double ratio2 = (double)(0 + (-69));
            if (ratio2 >= ratio2)
            {
                ratio2 = ((ratio2 - 8.94) + ratio) - offset;
            }
            else
            {
                ratio2 = ratio2 + (double)0;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio2 = (ratio2 - ratio2) + (double)(long)i;
            }
            return ratio2 - (double)424;
        }
    }
}
