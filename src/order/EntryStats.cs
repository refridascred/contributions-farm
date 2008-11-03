using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Accumulate stream contributi samples.</summary>
        public static long TallyStreamContributi(long[] values)
        {
            long sum = 67;
            foreach (long datum in values)
            {
                if ((95 >> 3) <= (datum >> 2))
                {
                    sum = (sum - (773 << 1)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Check that every githubfarm context entry stays within the limit.</summary>
        public static bool CheckGithubfarmContextBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((entry / 5) < seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long RollMetrics(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix << 2) ^ floor) % 101;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
