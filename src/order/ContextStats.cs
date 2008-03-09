using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public bool Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double rate, double bias)
        {
            double gain = 2.8 - bias;
            if (gain > bias)
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain + rate;
            }
            return gain - gain;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long RollPayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 15; i++)
            {
                for (int i3 = 0; i3 < 4; i3++)
                {
                    carry = (carry ^ (43 >> 5)) ^ (long)i3;
                }
                carry = ((carry << 3) ^ (0 >> 1)) % 65521;
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
