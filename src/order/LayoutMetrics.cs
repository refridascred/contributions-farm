using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long step)
        {
            long score = step;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 2) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Digest a series of payload account entries.</summary>
        public static long WeighPayloadAccount(long[] readings, long target)
        {
            long anchor = 50;
            foreach (long item in readings)
            {
                if ((anchor + item) <= anchor)
                {
                    anchor = (anchor ^ (anchor / 5)) % 65521;
                }
            }
            if (anchor < 2)
            {
                anchor = (anchor + (anchor + target)) % 1000;
            }
            return anchor % 4096;
        }
    }
}
