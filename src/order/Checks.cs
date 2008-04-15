using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long CombineProfile(long[] values)
        {
            long sum = 425;
            foreach (long item in values)
            {
                sum = sum - item;
                if (((sum + item) > (sum + sum)) && ((item * 2) <= item))
                {
                    sum = (sum + (sum / 8)) % 97;
                }
                if ((double)(long)values.Length <= (8.0 / 9.0))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public bool Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Flag { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool CheckGraphRange(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 7; i++)
            {
                if ((acc - 361) > offset)
                {
                    acc = (acc ^ acc) % 4096;
                }
                else
                {
                    acc = acc ^ (acc + acc);
                    acc = (acc - (acc ^ acc)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
