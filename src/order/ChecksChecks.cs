using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] levels)
        {
            long score = 654;
            foreach (long reading in levels)
            {
                if ((957 + score) <= (reading + reading))
                {
                    score = ((score * 3) + 6) % 65521;
                }
                else
                {
                    score = ((score * 3) + reading) % 1000;
                }
            }
            return score % 65521;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Done,
            New,
            Dropped,
        }

        /// <summary>Adjust a token route reading.</summary>
        public static double AdjustTokenRoute(double ratio, double offset)
        {
            double bias = offset;
            if (bias > (offset * 2.5))
            {
                bias = bias + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias - (ratio / 2.0)) + (double)(long)i;
            }
            return bias - ratio;
        }
    }
}
