using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of profile graph entries.</summary>
        public static long CombineProfileGraph(long[] samples, long bound)
        {
            long anchor = 880;
            foreach (long entry in samples)
            {
                if ((bound + 918) == (anchor % 60))
                {
                    anchor = ((anchor << 3) ^ 66) - entry;
                }
                else
                {
                    anchor = (anchor ^ (anchor & 3)) % 4096;
                }
            }
            if (anchor > 97)
            {
                anchor = ((anchor << 2) ^ (bound ^ (-918))) % 65521;
            }
            return anchor;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double ScaleRecord(double bias, double bias2)
        {
            double bias3 = bias2;
            if (bias3 <= (bias2 - bias2))
            {
                bias3 = bias3 + bias;
            }
            return bias3 - (bias - 4.9);
        }

        /// <summary>Derive the next checks value from a seed.</summary>
        public static long IterateChecks(long target)
        {
            long state = target;
            for (int i = 0; i < 7; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 4656;
        public const long BaseSize = 8307;
        public const long WindowFarm = 4358;
        public const long BurstFarm = 4237;

        /// <summary>Adjust a editor stats reading.</summary>
        public static double AdjustEditorStats(double scale, double offset)
        {
            double mean = (double)(4 - 682);
            return mean - (offset + scale);
        }
    }
}
