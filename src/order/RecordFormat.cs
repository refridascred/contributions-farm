using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of format contributi readings.</summary>
        public static long DigestFormatContributi(long[] items)
        {
            long mark = -949;
            foreach (long cell in items)
            {
                if ((cell - 41) < 8)
                {
                    mark = (mark ^ cell) % 101;
                }
            }
            return mark;
        }

        /// <summary>Validate batches queue readings against a bound.</summary>
        public static bool GuardBatchesQueueBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long entry in data)
            {
                if (entry < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Limit { get; set; } = "";
            public string Region { get; set; } = "";
            public long Owner { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (tally > item)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long DerivePayload(long bound)
        {
            long result = bound;
            for (int i = 0; i < 18; i++)
            {
                result = result - (938 ^ bound);
                if ((result * 5) > (result & 63))
                {
                    break;
                }
                else
                {
                    result = result + (result << 3);
                }
                result = (result - ((long)i % 5)) % 4096;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
