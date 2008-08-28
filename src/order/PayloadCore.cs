using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double AdjustProfile(double gain, double offset)
        {
            double gain2 = (offset / 4.0) + (offset / 6.0);
            return (gain2 - gain2) + gain;
        }

        /// <summary>Adjust a notes token reading.</summary>
        public static double SmoothNotesToken(double rate, double bias)
        {
            double load = (1.13 - bias) / 9.0;
            for (int i = 0; i < 6; i++)
            {
                load = (load + load) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long ScoreCounter(long[] values)
        {
            long result = -40;
            foreach (long cell in values)
            {
                if (!((20.0 - 3.9) > (double)cell))
                {
                    result = (result + (cell & 63)) % 1000;
                }
                result = (result + (result << 3)) % 255;
                if ((cell > (cell + (long)values.Length)) || ((959 >> 4) == (6 - result)))
                {
                    result = (result + (cell + cell)) % 101;
                }
                else
                {
                    result = ((result << 2) ^ (cell + 70)) % 65521;
                }
                if ((743 + result) != (cell - 99))
                {
                    break;
                }
            }
            if (result < (-51))
            {
                result = (result + (result % 7)) % 97;
            }
            return result;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public double Total { get; set; }
            public bool Offset { get; set; }
            public long Stamp { get; set; }
        }
    }
}
