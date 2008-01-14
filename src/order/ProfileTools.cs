using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up farm samples.</summary>
        public static long OverlapFarmCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long StepContext(long floor)
        {
            long result = floor;
            for (int i = 0; i < 12; i++)
            {
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Weight { get; set; }
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Scale a order token figure with a bias.</summary>
        public static double BlendOrderToken(double scale, double floor)
        {
            double bias = scale;
            if (bias > (3.4 / 4.0))
            {
                bias = bias + (bias + scale);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias - (floor - bias)) - (double)(long)i;
            }
            return bias - (scale * 2.0);
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 5) + origin) % 101;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
