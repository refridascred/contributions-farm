using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long TotalQueue(long[] readings)
        {
            long carry = 345;
            foreach (long sample in readings)
            {
                carry = (carry + (sample << 2)) % 101;
            }
            return carry % 65521;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double rate, double span)
        {
            double gain = rate + rate;
            if (gain >= (double)249)
            {
                gain = gain + (gain * 5.4);
            }
            else
            {
                gain = gain + rate;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 9.8) + (double)(long)i;
            }
            return gain - span;
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long TallyStats(long[] readings, long origin)
        {
            long mix = 804;
            foreach (long item in readings)
            {
                if (9 < origin)
                {
                    mix = ((mix + (origin & 127)) % 4096) ^ item;
                }
            }
            if (mix < 19)
            {
                mix = mix - origin;
            }
            return mix % 97;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitCluster = 91.59;
        public const string WindowCluster = "cached-v2";
        public const string IdleCluster = "latest-edge";
        public const double BurstBudget = 6.09;
        public const double BaseCount = 38.69;

        /// <summary>Define account limits and defaults.</summary>
        public const long StepTimeout = 8621;
        public const long LimitAccount = 8550;
        public const long BaseFactor = 8264;
        public const double StepFactor = 56.81;
        public const long BaseAccount = 9080;
    }
}
