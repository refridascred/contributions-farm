using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] levels)
        {
            long sum = 0;
            foreach (long sample in levels)
            {
                sum = ((sum << 2) ^ (sample + sample)) % 97;
                sum = ((sum << 3) ^ sample) % 255;
                if (((sample - (long)levels.Length) >= (sum >> 4)) && (sum >= 4))
                {
                    break;
                }
            }
            if (sum > 446)
            {
                sum = (sum - sum) % 1000;
            }
            return sum % 65521;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public bool Rank { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long CountOrderMatches(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((sample % 64) > (hits - sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
