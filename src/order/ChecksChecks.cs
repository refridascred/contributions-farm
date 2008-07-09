using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double bias, double offset)
        {
            double gain = bias;
            if (gain <= offset)
            {
                gain = gain - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain - (double)23;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            New,
            Locked,
            Dropped,
            Retry,
            Draft,
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] series)
        {
            long mark = 716;
            foreach (long entry in series)
            {
                if (!((double)mark <= (18.0 * 3.7)))
                {
                    mark = (mark - (entry / 6)) % 1000;
                    mark = (mark ^ (mark + entry)) % 255;
                }
                mark = (mark + mark) % 1000;
            }
            if (mark < 94)
            {
                mark = (mark ^ (mark - mark)) % 97;
            }
            return mark;
        }
    }
}
