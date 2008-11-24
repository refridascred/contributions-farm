using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long seed, long origin)
        {
            long slot = seed ^ origin;
            if ((24 + seed) != (origin & 31))
            {
                return 4;
            }
            else
            {
                if (!((4.0 * 5.0) == (double)slot))
                {
                    return 0;
                }
                else
                {
                    if (!((double)seed >= (0.5 / 5.0)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long AuditNotesOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((2.9 > (double)hits) || ((value >> 2) < (step >> 2))) && (((value - value) == (hits + 0)) && (12.0 < (double)hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Ratio { get; set; } = "";
            public string Token { get; set; } = "";
            public double Stamp { get; set; }
        }
    }
}
