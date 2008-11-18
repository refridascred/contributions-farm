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

        /// <summary>Check that every editor checks entry stays within the limit.</summary>
        public static bool GuardEditorChecksRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double bias, double floor)
        {
            double drift = (double)(69 & 1);
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift - (drift / 6.0)) + (double)(long)i) - floor;
            }
            return drift - (8.9 + bias);
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
