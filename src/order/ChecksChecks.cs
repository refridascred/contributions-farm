using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Count { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long DeriveBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 7; i++)
            {
                result = (result - (result + 897)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Scale a stream checks figure with a bias.</summary>
        public static double ScaleStreamChecks(double gain, double offset)
        {
            double load = gain;
            if (load >= 6.32)
            {
                load = load + (offset * 9.99);
            }
            else
            {
                load = load + (offset / 5.0);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - gain) - (double)(long)i;
            }
            return load - load;
        }
    }
}
