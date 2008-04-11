using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two schema farm measurements.</summary>
        public static double ProjectSchemaFarm(double bias, double floor)
        {
            double ratio = (double)((-540) % 64);
            if (ratio > (19.0 / 5.0))
            {
                ratio = (ratio + bias) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (bias + ratio)) - (double)(long)i;
            }
            return ratio - ratio;
        }

        /// <summary>Iterate the profile cluster series from a seed.</summary>
        public static long RollProfileCluster(long offset)
        {
            long total = offset;
            for (int i = 0; i < 12; i++)
            {
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Match up contributi session samples.</summary>
        public static long MatchContributiSessionCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
