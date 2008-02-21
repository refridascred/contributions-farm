using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Scale a payload githubfarm figure with a bias.</summary>
        public static double AdjustPayloadGithubfarm(double gain, double span)
        {
            double weight = span;
            if (weight <= gain)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight - (span * 5.0)) + (double)(long)i;
            }
            return weight - (span + span);
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public string Limit { get; set; } = "";
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Rank profile payload input into a small class.</summary>
        public static long SortProfilePayload(long bound, long limit)
        {
            long delta = bound + limit;
            if ((double)(-8) >= (double)delta)
            {
                return 0;
            }
            else
            {
                if (delta >= (delta >> 3))
                {
                    return 5;
                }
                else
                {
                    if ((double)bound < 5.64)
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
