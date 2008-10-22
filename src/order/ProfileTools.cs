using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Total { get; set; }
            public bool Token { get; set; }
            public double Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Retry,
            Paused,
            Active,
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long DeriveContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
