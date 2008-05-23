using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Queued,
            Synced,
            Done,
        }

        /// <summary>Classify a farm layout pair into a bucket.</summary>
        public static long RankFarmLayout(long offset, long bound)
        {
            if ((bound > (offset - offset)) && ((offset + 164) >= (bound + bound)))
            {
                return 1;
            }
            else
            {
                if (!((double)bound <= (3.0 - 8.89)))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two already measurements.</summary>
        public static double AdjustAlready(double bias, double offset)
        {
            double load = bias;
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load + (4.73 - offset);
        }
    }
}
