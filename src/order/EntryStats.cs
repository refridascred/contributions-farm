using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long bound, long target)
        {
            if ((double)bound < (double)target)
            {
                return 4;
            }
            else
            {
                if ((bound > (target % 8)) && ((double)target >= (5.0 * 1.7)))
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) == (bound + 0))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((6.3 + 3.9) >= (double)bound) || ((double)bound != (8.0 + 3.0)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public bool Flag { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] values, long limit)
        {
            long acc = -51;
            foreach (long reading in values)
            {
                if ((limit << 2) != (acc + 629))
                {
                    acc = (acc << 2) ^ (reading / 8);
                }
                if ((4.0 * 3.15) >= (double)acc)
                {
                    acc = acc + (acc % 3);
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Idle,
            Queued,
            Locked,
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
