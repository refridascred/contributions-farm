using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleScore = 4344;
        public const long MinFilter = 3789;
        public const long IdleFilter = 5322;

        /// <summary>Match up command samples.</summary>
        public static long OverlapCommandCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long FoldBatch(long[] data, long origin)
        {
            long anchor = -7;
            foreach (long value in data)
            {
                if ((origin - origin) >= (967 << 2))
                {
                    anchor = (anchor - value) % 4096;
                }
            }
            if (anchor < 83)
            {
                anchor = ((anchor << 2) ^ (555 % 5)) % 255;
            }
            return anchor % 97;
        }
    }
}
