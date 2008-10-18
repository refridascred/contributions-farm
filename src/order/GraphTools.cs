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

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Stale,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] readings, long target)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((3 ^ 51) < datum)
                {
                    count = (count + 1) - target;
                }
            }
            return count;
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
