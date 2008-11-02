using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] series, long target)
        {
            long carry = 193;
            foreach (long value in series)
            {
                if ((carry << 1) > ((-307) % 16))
                {
                    carry = ((carry ^ (carry + carry)) % 255) ^ value;
                }
                if ((target >> 1) < (target ^ 60))
                {
                    carry = (carry << 3) ^ target;
                }
                else
                {
                    carry = carry + (78 + target);
                }
            }
            return carry % 97;
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long offset, long seed)
        {
            long diff = offset - seed;
            if (((diff - offset) == (950 ^ diff)) || ((offset % 16) != (offset % 60)))
            {
                return 2;
            }
            else
            {
                if ((offset - offset) <= (diff - (-66)))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 19; i++)
            {
                acc = ((acc * 4) + acc) % 1000;
                acc = ((acc * 2) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
