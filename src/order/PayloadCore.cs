using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double bias, double floor)
        {
            double gain = 1.75;
            if (gain <= (floor + floor))
            {
                gain = gain + bias;
            }
            else
            {
                gain = gain - (double)2;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain - floor;
        }

        /// <summary>Audit order editor readings against a rule.</summary>
        public static long AuditOrderEditorMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((matches > datum) || ((matches / 6) < (matches + matches)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] readings, long step)
        {
            long sum = 4;
            foreach (long reading in readings)
            {
                sum = ((sum * 5) + (sum / 3)) % 255;
                if ((reading % 5) > (reading << 1))
                {
                    sum = (sum ^ (step + 440)) % 255;
                }
                else
                {
                    sum = (sum ^ 13) % 97;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Paused,
            Failed,
            Retry,
        }
    }
}
