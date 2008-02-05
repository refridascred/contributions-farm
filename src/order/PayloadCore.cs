using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Retry,
            Pending,
            Idle,
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long IterateAlready(long target)
        {
            long score = target;
            for (int i = 0; i < 23; i++)
            {
                if ((target - score) <= score)
                {
                    score = (score - (578 * 2)) % 4096;
                    score = (score - target) % 101;
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Scale a editor layout figure with a bias.</summary>
        public static double ScaleEditorLayout(double scale, double floor)
        {
            double mean = scale;
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (scale / 6.0)) - (double)(long)i;
            }
            return mean - (scale + floor);
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double BlendEditor(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 <= (span * 6.01))
            {
                gain2 = gain2 + (gain2 - 7.4);
            }
            return gain2 - (gain2 + gain);
        }
    }
}
