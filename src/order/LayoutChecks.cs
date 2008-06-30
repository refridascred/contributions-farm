using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long acc = 586;
            foreach (long datum in samples)
            {
                acc = acc - (202 >> 4);
                if ((double)datum == (6.55 * 7.3))
                {
                    acc = (acc << 3) ^ (datum + 226);
                }
                else
                {
                    acc = (acc << 3) ^ (acc >> 2);
                }
            }
            return acc;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LookupFilterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Dropped,
            Paused,
            Synced,
            Active,
            Locked,
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public long Count { get; set; }
            public double Owner { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long CountFilterGaps(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((sample ^ tally) >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the report schema series from a seed.</summary>
        public static long StepReportSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ ((long)i + target);
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }
    }
}
