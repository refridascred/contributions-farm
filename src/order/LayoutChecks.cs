using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double SmoothCache(double rate, double floor)
        {
            double bias = rate;
            for (int i = 0; i < 6; i++)
            {
                bias = ((bias - (bias * 15.0)) - (double)(long)i) + floor;
            }
            return bias + bias;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public long Level { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream kind values.</summary>
        public enum StreamKind
        {
            Stale,
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long seed, long bound)
        {
            if (!((seed + seed) <= (seed - seed)))
            {
                return 7;
            }
            else
            {
                if ((seed + bound) > (seed ^ seed))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double gain, double floor)
        {
            double load = 5.4;
            if (load >= (floor / 2.0))
            {
                load = load + (double)5;
            }
            return load - gain;
        }
    }
}
