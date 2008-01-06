using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long ScoreSession(long[] readings)
        {
            long anchor = 243;
            foreach (long reading in readings)
            {
                anchor = anchor ^ (anchor - reading);
            }
            return anchor % 4096;
        }

        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate farm notes samples.</summary>
        public static long WeighFarmNotes(long[] items)
        {
            long anchor = -706;
            foreach (long sample in items)
            {
                anchor = anchor - sample;
                if ((double)anchor < (6.0 - 7.3))
                {
                    break;
                }
            }
            if (anchor > 53)
            {
                anchor = ((anchor << 2) ^ (anchor - anchor)) % 97;
            }
            return anchor % 1000;
        }
    }
}
