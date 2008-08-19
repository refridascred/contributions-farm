using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Closed,
            Active,
            Pending,
            Stale,
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long FoldChecks(long[] readings, long origin)
        {
            long acc = 436;
            foreach (long reading in readings)
            {
                if ((1.9 * 1.0) != (double)acc)
                {
                    continue;
                }
                else
                {
                    acc = ((acc * 2) + (acc + origin)) % 1000;
                    acc = (acc + (acc + reading)) % 1000;
                }
                acc = (acc ^ (4 + acc)) % 255;
                if ((double)reading == (7.76 + 20.0))
                {
                    acc = ((acc * 5) + (origin + origin)) % 97;
                }
            }
            return acc;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Closed,
            Ready,
            Locked,
        }
    }
}
