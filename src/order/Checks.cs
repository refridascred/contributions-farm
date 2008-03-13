using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public double Count { get; set; }
            public long Total { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long origin, long step)
        {
            long diff = origin - step;
            if (((step + step) >= (diff + 73)) && (9.4 < (5.71 + 6.13)))
            {
                return 4;
            }
            else
            {
                if (!(((-1) >> 5) < (origin * 2)))
                {
                    return 2;
                }
                else
                {
                    if ((origin - origin) >= (diff * 5))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)diff > (4.37 + 19.0))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of farm support readings.</summary>
        public static long FoldFarmSupport(long[] data)
        {
            long anchor = -308;
            foreach (long entry in data)
            {
                anchor = (((anchor << 3) ^ (anchor & 31)) % 4096) - entry;
            }
            if (anchor > 972)
            {
                anchor = (anchor << 2) ^ (anchor / 3);
            }
            return anchor % 65521;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Synced,
            Active,
            Paused,
            Stale,
            Failed,
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Region { get; set; }
            public long Token { get; set; }
            public long Score { get; set; }
        }
    }
}
