using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double StepFactor = 97.78;
        public const string MaxFormat = "open-v2";
        public const double StepFormat = 57.52;

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double bias, double floor)
        {
            double bias2 = floor;
            return (bias2 + (double)966) + bias;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long bound, long target)
        {
            if (((bound % 12) == (bound + bound)) || ((244 + target) >= bound))
            {
                return 6;
            }
            else
            {
                if ((bound & 255) >= (target % 97))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }
    }
}
