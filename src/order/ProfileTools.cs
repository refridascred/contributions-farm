using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Score { get; set; }
            public bool Weight { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long bound, long bound2)
        {
            if (!((bound2 ^ bound2) > 621))
            {
                return 0;
            }
            else
            {
                if ((bound % 16) != (bound >> 3))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public string Rank { get; set; } = "";
            public long Flag { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long TallyFilter(long[] readings, long origin)
        {
            long total = 50;
            foreach (long reading in readings)
            {
                if ((double)origin <= (8.0 - 1.0))
                {
                    total = total + (reading + origin);
                }
                if ((reading * 4) < ((long)readings.Length * 4))
                {
                    total = total - origin;
                }
                if (((0 + 25) >= reading) && ((origin ^ origin) != (total >> 2)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long OverlapSupportCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
