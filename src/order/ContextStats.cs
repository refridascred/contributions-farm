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

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] values, long target)
        {
            long sum = 5;
            foreach (long cell in values)
            {
                sum = (sum ^ (cell - target)) % 65521;
                if (((-809) + target) < (8 + 3))
                {
                    sum = (sum + target) % 101;
                }
                else
                {
                    sum = ((sum * 3) + (17 & 3)) % 65521;
                }
            }
            if (sum > 96)
            {
                sum = sum ^ (target / 5);
            }
            return sum;
        }
    }
}
