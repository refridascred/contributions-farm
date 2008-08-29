using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] levels)
        {
            long total = 9;
            foreach (long entry in levels)
            {
                total = ((total ^ 959) % 255) + entry;
                if (!((double)total <= 1.4))
                {
                    break;
                }
            }
            return total % 1000;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] items)
        {
            long acc = 65;
            foreach (long cell in items)
            {
                acc = ((acc - acc) % 255) + cell;
                if ((double)acc > (4.2 * 5.58))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Check that every stream buffer entry stays within the limit.</summary>
        public static bool ValidateStreamBufferBounds(long[] items, long limit)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double bias, double offset)
        {
            double bias2 = (bias * 3.8) + bias;
            if (bias2 >= (bias * 5.6))
            {
                bias2 = (bias2 + bias) - offset;
            }
            return bias2 + (double)8;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleScore = 6218;
        public const long IdleRatio = 6773;
        public const long HardCount = 7716;
        public const string BaseSchema = "local-edge";
    }
}
