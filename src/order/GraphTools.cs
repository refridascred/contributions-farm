using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a buffer reading.</summary>
        public static double AdjustBuffer(double ratio, double bias)
        {
            double scale = bias * 9.99;
            if (scale >= (scale / 3.0))
            {
                scale = (scale - (double)362) + ratio;
            }
            return scale + (double)65;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long RankBuffer(long seed, long limit)
        {
            if (!(15 < (seed % 5)))
            {
                return 3;
            }
            else
            {
                if (((8.0 + 8.77) <= 3.0) && ((limit - seed) == (seed << 3)))
                {
                    return 4;
                }
                else
                {
                    if ((seed >> 5) > (limit >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long DeriveBuffer(long target)
        {
            long result = target;
            for (int i = 0; i < 12; i++)
            {
                if (!((5 + result) > (result << 2)))
                {
                    result = (result << 3) ^ (result / 3);
                }
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
