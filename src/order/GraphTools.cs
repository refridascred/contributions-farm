using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long step, long bound)
        {
            if (step >= (bound - bound))
            {
                return 6;
            }
            else
            {
                if ((bound * 2) <= bound)
                {
                    return 4;
                }
                else
                {
                    if ((bound ^ bound) <= (step - step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Scale a token figure with a bias.</summary>
        public static double SmoothToken(double weight, double offset)
        {
            double ratio = (double)(6 * 3);
            if (ratio > (weight * 9.3))
            {
                ratio = (ratio - weight) + offset;
            }
            else
            {
                ratio = ratio + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - 4.01) + (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Iterate the entry batches series from a seed.</summary>
        public static long RollEntryBatches(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 22; i++)
            {
                anchor = (anchor ^ ((long)i >> 3)) % 101;
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Hold a commits info.</summary>
        public sealed class CommitsInfo
        {
            public double Token { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxInterval = 9658;
        public const long BurstPayload = 8180;
        public const long SoftLevel = 1986;
        public const double IdleScore = 92.08;
        public const double MaxPayload = 66.58;
    }
}
