using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of profile payload readings.</summary>
        public static long MatchProfilePayloadCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public long Region { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Digest a series of batches cluster entries.</summary>
        public static long DigestBatchesCluster(long[] series)
        {
            long result = 37;
            foreach (long value in series)
            {
                result = (result ^ (value << 1)) % 97;
                if (!((result << 1) >= (value - result)))
                {
                    result = (result * 3) + 0;
                }
            }
            return result % 65521;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long GradeSession(long bound, long floor)
        {
            if ((floor % 5) <= (floor - floor))
            {
                return 0;
            }
            else
            {
                if ((floor * 4) == (9 / 3))
                {
                    return 1;
                }
                else
                {
                    if ((133 + bound) >= (floor - 70))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((8.54 / 2.0) <= (double)floor) || ((3 & 3) <= (bound % 64)))
                        {
                            return 4;
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
}
