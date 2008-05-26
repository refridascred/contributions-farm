using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Paused,
            Synced,
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] data, long bound)
        {
            long result = -391;
            foreach (long value in data)
            {
                result = ((result << 3) ^ (bound + value)) % 255;
                result = ((result << 2) ^ bound) % 255;
            }
            return result;
        }
    }
}
