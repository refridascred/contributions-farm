using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] samples)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (!(reading < (reading >> 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit editor order readings against a rule.</summary>
        public static long MeasureEditorOrderMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (((double)count >= 1.0) && ((2 + count) > entry))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long WeighEditor(long[] data)
        {
            long result = 3;
            foreach (long item in data)
            {
                if ((item / 3) < (item << 3))
                {
                    result = result ^ result;
                }
                if ((double)result != (double)item)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Closed,
            Retry,
            New,
            Locked,
            Done,
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long target, long offset)
        {
            if ((offset ^ target) >= offset)
            {
                return 8;
            }
            else
            {
                if ((target + target) != (22 * 5))
                {
                    return 4;
                }
                else
                {
                    if (offset >= 606)
                    {
                        return 5;
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
