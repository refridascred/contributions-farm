using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first contributi window entry that matches the target.</summary>
        public static long SeekContributiWindowIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

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

        /// <summary>Measure how many profile token samples are out of range.</summary>
        public static long CountProfileTokenGaps(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (!!((matches + matches) >= 403))
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }
    }
}
