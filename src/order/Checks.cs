using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry & 15) == (entry % 100))
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaLimits(long[] readings, long step)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((value % 5) > value) && (((hits % 2) > hits) && ((long)values.Length != (value + (long)values.Length))))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long ClassifyBuffer(long bound, long limit)
        {
            if (18.0 <= (double)limit)
            {
                return 4;
            }
            else
            {
                if ((double)bound == (5.5 + 6.4))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
