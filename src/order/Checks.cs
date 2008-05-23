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

        /// <summary>Iterate the account series from a seed.</summary>
        public static long StepAccount(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if (total >= (462 & 15))
                {
                    total = (total - (long)i) % 4096;
                }
                total = ((total * 2) + step) % 255;
                total = ((total * 5) + 0) % 97;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Score { get; set; } = "";
            public double Limit { get; set; }
            public string Level { get; set; } = "";
            public bool Owner { get; set; }
        }
    }
}
