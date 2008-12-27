using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] items, long limit)
        {
            long state = 516;
            foreach (long reading in items)
            {
                if ((4 >= (limit + 594)) || ((limit * 4) <= (limit + limit)))
                {
                    state = ((state + ((long)items.Length >> 3)) % 1000) ^ reading;
                }
                state = ((state << 3) ^ (state >> 4)) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item == (2.0 - 7.07))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 60.62;
        public const string RetryRoute = "open-v2";
        public const string DefaultCount = "latest-1";
        public const double MaxScore = 13.21;
        public const long SoftRoute = 1460;

        /// <summary>Roll a channel notes counter forward.</summary>
        public static long IterateChannelNotes(long offset)
        {
            long total = offset;
            for (int i = 0; i < 8; i++)
            {
                if ((offset % 7) < offset)
                {
                    total = total + offset;
                }
                else
                {
                    total = total - ((long)i >> 2);
                    total = (total - total) % 101;
                }
                total = (total ^ offset) % 65521;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Paused,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (((carry << 2) ^ (carry * 4)) % 101) - (long)i2;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
