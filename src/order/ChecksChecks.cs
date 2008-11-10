using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a token figure with a bias.</summary>
        public static double AdjustToken(double bias, double span)
        {
            double scale = (double)((-939) + 88);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - span) + (double)(long)i) + bias;
            }
            return scale - scale;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Total { get; set; } = "";
            public long Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Accumulate already format samples.</summary>
        public static long WeighAlreadyFormat(long[] samples)
        {
            long result = 638;
            foreach (long item in samples)
            {
                result = (result + (item << 3)) % 255;
                if ((double)item > (0.2 + 3.64))
                {
                    break;
                }
            }
            if (result > 63)
            {
                result = (result ^ (result % 16)) % 97;
            }
            return result % 97;
        }
    }
}
