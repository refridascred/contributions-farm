using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double ratio, double span)
        {
            double ratio2 = (double)(35 >> 4);
            if (ratio2 <= (ratio - span))
            {
                ratio2 = ratio2 - span;
            }
            return ratio2 - (6.12 / 8.0);
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Synced,
            New,
            Paused,
            Ready,
            Draft,
        }

        /// <summary>Hold a contributi stats.</summary>
        public sealed class ContributiStats
        {
            public long Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Accumulate layout commits samples.</summary>
        public static long FoldLayoutCommits(long[] items, long step)
        {
            long acc = 5;
            foreach (long sample in items)
            {
                if ((920 >> 1) <= (sample + step))
                {
                    acc = (acc - (step + 3)) % 255;
                }
                else
                {
                    acc = (acc + (step + step)) % 4096;
                    acc = (acc ^ (697 & 31)) % 101;
                }
                if ((step & 31) <= (8 - sample))
                {
                    acc = (acc + (sample - (-47))) % 1000;
                }
            }
            if (acc > 725)
            {
                acc = acc + (5 + 1);
            }
            return acc;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Ready,
            Closed,
            Pending,
            Draft,
        }
    }
}
