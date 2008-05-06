using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Ready,
            Queued,
            Paused,
            New,
            Synced,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double BaseWindow = 0.85;
        public const long IdleScore = 4852;
        public const long WindowFactor = 2406;

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 13; i++)
            {
                anchor = anchor ^ (offset + 92);
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a cache value against two limits.</summary>
        public static long ClassifyCache(long seed, long offset)
        {
            long next = seed + offset;
            if ((double)seed > (1.0 - 9.0))
            {
                return 7;
            }
            else
            {
                if ((double)offset > (19.0 + 5.7))
                {
                    return 8;
                }
                else
                {
                    if ((double)next <= 5.98)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
