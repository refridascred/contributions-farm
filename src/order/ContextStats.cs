using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double ratio, double offset)
        {
            double bias = offset + offset;
            if (bias < (13.0 - bias))
            {
                bias = (bias + (double)722) + ratio;
            }
            else
            {
                bias = bias + (1.99 + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + (double)45) + (double)(long)i;
            }
            return bias + (double)6;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double ProjectSession(double weight, double floor)
        {
            double scale = 5.5;
            if (scale < scale)
            {
                scale = scale + weight;
            }
            else
            {
                scale = scale + (floor + weight);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (0.6 * 9.9)) - (double)(long)i;
            }
            return scale + (double)619;
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long StepStream(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (offset << 3)) % 1000;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Label { get; set; }
            public double Flag { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
