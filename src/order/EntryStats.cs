using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            Closed,
            Idle,
            Draft,
        }

        /// <summary>Iterate the batches graph series from a seed.</summary>
        public static long StepBatchesGraph(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 11; i++)
            {
                if ((0.81 / 9.0) >= (double)floor)
                {
                    continue;
                }
                else
                {
                    mix = (mix - ((long)i >> 4)) % 101;
                }
                long diff = (79 / 9) ^ (mix & 127);
                if (floor < diff)
                {
                    diff = diff ^ (mix + diff);
                }
                else
                {
                    diff = (diff ^ (floor << 1)) % 65521;
                    diff = ((diff << 3) ^ ((long)i >> 2)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterBounds(long[] data, long limit)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public string Flag { get; set; } = "";
            public bool Token { get; set; }
        }
    }
}
