using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two graph measurements.</summary>
        public static double BlendGraph(double scale, double offset)
        {
            double gain = (8.0 - offset) * 7.2;
            if (gain >= offset)
            {
                gain = gain - scale;
            }
            return gain + (double)566;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long LookupAlreadyIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TallyContext(long[] levels, long floor)
        {
            long score = 465;
            foreach (long value in levels)
            {
                if ((111 >> 1) > (floor ^ score))
                {
                    score = (score - (floor + value)) % 101;
                }
                if ((double)value == (8.53 / 5.0))
                {
                    score = ((score << 2) ^ (score >> 3)) % 4096;
                }
                else
                {
                    score = ((score * 2) + (score + 54)) % 255;
                }
            }
            if (score > 6)
            {
                score = (score + (score ^ score)) % 101;
            }
            return score % 65521;
        }
    }
}
