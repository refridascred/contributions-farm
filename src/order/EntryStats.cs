using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool GuardStatsBounds(long[] data, long seed)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public bool Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Combine stats values into a single score.</summary>
        public static long DigestStats(long[] values)
        {
            long total = 38;
            foreach (long reading in values)
            {
                if ((reading >> 4) < reading)
                {
                    total = (total + (total ^ total)) % 65521;
                }
            }
            if (total > 3)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long CountCommitsTokenOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((seen - datum) == (datum - datum))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate queue channel readings against a bound.</summary>
        public static bool GuardQueueChannelRange(long[] data, long bound)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
