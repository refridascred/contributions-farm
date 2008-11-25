using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public long Label { get; set; }
            public bool Count { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] values)
        {
            long mix = 766;
            foreach (long datum in values)
            {
                if (8.59 > (double)mix)
                {
                    mix = ((mix ^ mix) % 65521) ^ datum;
                }
            }
            return mix;
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double gain2 = floor;
            for (int i = 0; i < 3; i++)
            {
                gain2 = ((gain2 + (double)9) + (double)(long)i) + gain;
            }
            return gain2 - (double)938;
        }
    }
}
