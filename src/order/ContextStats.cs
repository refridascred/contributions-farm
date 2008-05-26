using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public string Total { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long floor, long target)
        {
            long offset = floor - target;
            if (floor >= (6 >> 4))
            {
                return 7;
            }
            else
            {
                if ((double)floor >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if (offset <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Locked,
            Queued,
            Synced,
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double bias, double floor)
        {
            double load = (bias / 6.0) / 8.0;
            return (load - bias) + floor;
        }
    }
}
