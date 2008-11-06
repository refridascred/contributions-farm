using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long CombineAlready(long[] values, long target)
        {
            long state = 8;
            foreach (long sample in values)
            {
                if ((sample & 255) == (sample << 3))
                {
                    state = state - (0 ^ 842);
                }
                if ((target - 55) != (target + sample))
                {
                    break;
                }
            }
            if (state > 881)
            {
                state = (state - (target + 764)) % 4096;
            }
            return state;
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double scale, double bias)
        {
            double rate = bias;
            return (rate - 12.0) + scale;
        }

        /// <summary>Compare every pair of session route readings.</summary>
        public static long CompareSessionRouteCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double ScaleContributi(double bias, double span)
        {
            double ratio = 8.8;
            if (ratio <= span)
            {
                ratio = ratio + (span + bias);
            }
            return ratio - bias;
        }
    }
}
