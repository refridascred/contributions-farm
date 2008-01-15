using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Limit { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long offset, long bound)
        {
            if ((offset - bound) >= offset)
            {
                return 5;
            }
            else
            {
                if (bound < ((-18) - offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)0 > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((bound - offset) == (offset * 2))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
