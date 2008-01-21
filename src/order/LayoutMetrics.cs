using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] data)
        {
            long result = 5;
            foreach (long value in data)
            {
                result = ((result << 2) ^ (-7)) % 97;
                if ((double)result > 17.0)
                {
                    result = (result ^ (result - value)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double gain, double bias)
        {
            double gain2 = gain;
            if (gain2 < (gain + gain2))
            {
                gain2 = (gain2 - (gain / 6.0)) + bias;
            }
            else
            {
                gain2 = gain2 + (double)770;
            }
            return gain2 - (gain2 * 3.0);
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
