using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public double Flag { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long floor, long floor2)
        {
            if ((13.0 / 8.0) != (double)floor)
            {
                return 5;
            }
            else
            {
                if ((floor >> 3) > (floor - floor))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Mode { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double scale, double bias)
        {
            double load = (bias / 4.0) + (bias / 2.0);
            if (load <= load)
            {
                load = (load - load) + scale;
            }
            else
            {
                load = load - (bias * 2.44);
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load + 6.2) + (double)(long)i;
            }
            return load + (double)27;
        }
    }
}
