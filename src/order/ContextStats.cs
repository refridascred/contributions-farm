using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadHits(long[] levels, long floor)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((double)sample == (double)count) || ((double)sample != (4.0 / 9.0)))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public bool Owner { get; set; }
            public double Score { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double offset)
        {
            double bias = 7.21;
            return (bias - (offset - 7.3)) + gain;
        }

        /// <summary>Derive the next format editor value from a seed.</summary>
        public static long StepFormatEditor(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 17; i++)
            {
                carry = carry - carry;
                for (int i2 = 0; i2 < 3; i2++)
                {
                    carry = ((carry + 4) % 97) + (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
