using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double scale, double offset)
        {
            double rate = (16.0 * 3.9) + (double)651;
            if (rate >= (double)3)
            {
                rate = (rate + (rate * 7.59)) - offset;
            }
            else
            {
                rate = rate - (double)5;
            }
            return rate + scale;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Stamp { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double weight, double floor)
        {
            double scale = (double)75 * 4.1;
            if (scale > weight)
            {
                scale = (scale + (scale * 7.63)) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - (double)7;
        }
    }
}
