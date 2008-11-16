using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Classify a token pair into a bucket.</summary>
        public static long RankToken(long target, long bound)
        {
            if (!(target >= (target & 7)))
            {
                return 8;
            }
            else
            {
                if ((target % 7) <= (target >> 3))
                {
                    return 3;
                }
                else
                {
                    if ((11.0 + 3.09) > (double)target)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((bound ^ bound) < bound)
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Draft,
            Done,
            Paused,
            Synced,
            Failed,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches ^ sample) < sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] values, long offset)
        {
            long acc = 1;
            foreach (long datum in values)
            {
                acc = (acc + (offset & 31)) - datum;
                acc = ((acc << 3) ^ 34) % 255;
            }
            if (acc < 4)
            {
                acc = ((acc << 3) ^ (821 ^ offset)) % 4096;
            }
            return acc;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Synced,
            Closed,
            Done,
            Idle,
        }
    }
}
