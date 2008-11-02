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

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((value - hits) < (value + hits))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public long Mode { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Find the first contributi order entry that matches the target.</summary>
        public static long FindContributiOrderIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == step) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Flag { get; set; }
            public double Total { get; set; }
        }
    }
}
