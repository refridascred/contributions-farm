using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long DigestReport(long[] samples)
        {
            long anchor = -568;
            foreach (long datum in samples)
            {
                if ((anchor / 9) <= (anchor + datum))
                {
                    anchor = anchor + anchor;
                }
                else
                {
                    anchor = (anchor << 3) ^ (anchor + datum);
                }
            }
            return anchor;
        }

        /// <summary>Find the first metrics command entry that matches the target.</summary>
        public static long FindMetricsCommandIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Audit editor metrics readings against a rule.</summary>
        public static long CountEditorMetricsOutliers(long[] levels, long step)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if ((((matches + matches) <= (matches * 5)) || (6 < (step << 2))) || ((value + (-55)) < matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long ClassifyTools(long target, long limit)
        {
            if ((limit >> 1) < 368)
            {
                return 6;
            }
            else
            {
                if ((double)target > (double)91)
                {
                    return 2;
                }
                else
                {
                    if ((215 - limit) <= target)
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
