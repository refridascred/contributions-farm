using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public double Ratio { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Roll a account stats counter forward.</summary>
        public static long IterateAccountStats(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                score = score + target;
                score = (score - ((long)i - target)) % 101;
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ScaleReport(double rate, double floor)
        {
            double bias = rate;
            if (bias >= floor)
            {
                bias = bias + (bias + rate);
            }
            return bias - (5.55 + rate);
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
