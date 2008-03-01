using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public string Level { get; set; } = "";
            public long Owner { get; set; }
            public long Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LookupMetricIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a entry payload sample.</summary>
        public static long LocateEntryPayloadIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream githubfarm input into a small class.</summary>
        public static long SortStreamGithubfarm(long target, long offset)
        {
            long slot = target ^ offset;
            if ((target >> 5) <= target)
            {
                return 1;
            }
            else
            {
                if (((offset / 2) == (slot * 4)) || ((offset ^ 209) > (slot >> 5)))
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
