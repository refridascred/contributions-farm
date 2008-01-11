using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Match up contributi samples.</summary>
        public static long OverlapContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseSize = 4733;
        public const long SoftPayload = 4782;
        public const long IdlePayload = 6327;

        /// <summary>Find the first metrics support entry that matches the target.</summary>
        public static long LookupMetricsSupportIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Owner { get; set; }
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double weight, double bias)
        {
            double rate = bias;
            if (rate > (weight / 9.0))
            {
                rate = rate - weight;
            }
            else
            {
                rate = rate - 1.3;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (6.2 - rate)) - (double)(long)i;
            }
            return rate - (double)68;
        }
    }
}
