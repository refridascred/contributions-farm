using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double bias, double span)
        {
            double mean = (bias + bias) - 17.0;
            if (mean >= (mean + mean))
            {
                mean = (mean - mean) - span;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - bias) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BurstToken = "local";
        public const double BaseToken = 96.27;
        public const long DefaultWidth = 5782;
        public const long StepWidth = 8501;
        public const long IdleToken = 2794;

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] items)
        {
            long anchor = 390;
            foreach (long datum in items)
            {
                anchor = (anchor ^ (anchor - datum)) % 255;
                if ((datum - datum) < (datum << 1))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Closed,
            Idle,
            Pending,
            Paused,
            Queued,
        }
    }
}
