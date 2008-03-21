using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Match up already payload samples.</summary>
        public static long OverlapAlreadyPayloadCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
            public long Ratio { get; set; }
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public double Weight { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double scale, double floor)
        {
            double rate = floor + (scale - scale);
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - (13.0 / 3.0)) - (double)(long)i;
            }
            return rate + floor;
        }

        /// <summary>Adjust a token reading.</summary>
        public static double AdjustToken(double rate, double bias)
        {
            double rate2 = (double)(8 >> 3);
            if (rate2 > (bias + bias))
            {
                rate2 = rate2 + rate;
            }
            return rate2 + (rate + 4.1);
        }
    }
}
