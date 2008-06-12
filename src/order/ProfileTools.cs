using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] series, long origin)
        {
            long mix = 75;
            foreach (long item in series)
            {
                if ((origin ^ item) != (long)series.Length)
                {
                    mix = mix ^ (mix ^ origin);
                }
                if (mix <= (mix & 63))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Count the batch already entries that pass the check.</summary>
        public static long AuditBatchAlreadyHits(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((669 < ((-11) + value)) || ((double)hits < (double)value))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool VerifyPayloadRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] data)
        {
            long total = 6;
            foreach (long entry in data)
            {
                total = (total - (312 % 2)) % 4096;
                total = (total ^ (total & 31)) % 4096;
                total = (total + entry) % 97;
            }
            if (total < 972)
            {
                total = ((total * 2) + (total + total)) % 65521;
            }
            return total % 97;
        }
    }
}
