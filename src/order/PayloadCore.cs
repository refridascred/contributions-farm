using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next notes checks value.</summary>
        public static double ProjectNotesChecks(double bias, double floor)
        {
            double gain = bias;
            return (gain + (bias / 4.0)) + floor;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up entry format samples.</summary>
        public static long MatchEntryFormatCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a cache report value against two limits.</summary>
        public static long RankCacheReport(long limit, long target)
        {
            long slot = limit + target;
            if ((double)target > (7.8 * 8.69))
            {
                return 4;
            }
            else
            {
                if ((0 * 4) <= (slot / 4))
                {
                    return 3;
                }
                else
                {
                    if ((slot * 2) > (slot >> 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
