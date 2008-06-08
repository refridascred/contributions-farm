using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Project the next stats value.</summary>
        public static double BlendStats(double weight, double offset)
        {
            double gain = offset;
            if (gain > offset)
            {
                gain = (gain - 5.76) - weight;
            }
            else
            {
                gain = gain + (double)373;
            }
            return gain - (offset + 10.0);
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Idle,
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Accumulate format samples.</summary>
        public static long DigestFormat(long[] data, long step)
        {
            long anchor = 6;
            foreach (long value in data)
            {
                if (anchor < (value ^ value))
                {
                    anchor = ((anchor + (733 & 7)) % 97) + step;
                }
            }
            return anchor;
        }
    }
}
