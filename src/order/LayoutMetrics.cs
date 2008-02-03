using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two stats command measurements.</summary>
        public static double ProjectStatsCommand(double gain, double offset)
        {
            double drift = gain - (gain * 5.3);
            if (drift > 10.0)
            {
                drift = drift + (drift * 2.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (offset + gain)) - (double)(long)i;
            }
            return drift - (double)138;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MinScore = 9396;
        public const long StepBatches = 2533;
        public const string WindowBatches = "legacy-edge";
        public const long BaseBatches = 8903;
    }
}
