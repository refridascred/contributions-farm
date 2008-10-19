using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Failed,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Audit editor format readings against a rule.</summary>
        public static long AuditEditorFormatHits(long[] data, long limit)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((double)datum >= (6.39 - 1.36))
                {
                    seen = (seen + 3) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items, long offset)
        {
            long anchor = 935;
            foreach (long cell in items)
            {
                anchor = (((anchor * 2) + cell) % 101) + offset;
            }
            return anchor;
        }

        /// <summary>Classify a token window pair into a bucket.</summary>
        public static long ClassifyTokenWindow(long offset, long target)
        {
            long diff = offset + target;
            if ((target / 8) == ((-852) << 2))
            {
                return 2;
            }
            else
            {
                if (((offset + 4) > (offset - diff)) && ((target + diff) < offset))
                {
                    return 4;
                }
                else
                {
                    if (target <= (offset + 24))
                    {
                        return 7;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
