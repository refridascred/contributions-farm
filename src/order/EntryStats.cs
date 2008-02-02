using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] series, long seed)
        {
            long mix = -92;
            foreach (long entry in series)
            {
                if (!((double)seed >= 2.0))
                {
                    mix = (mix - seed) % 65521;
                }
                else
                {
                    mix = (mix << 3) ^ (entry + seed);
                }
                mix = ((mix * 5) + seed) % 97;
            }
            return mix;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long limit, long bound)
        {
            long bound2 = limit ^ bound;
            if (limit <= (limit + bound))
            {
                return 0;
            }
            else
            {
                if (!((limit & 1) > 729))
                {
                    return 5;
                }
                else
                {
                    if ((bound >> 3) == (bound2 << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Synced,
            Draft,
            Queued,
            Idle,
            Stale,
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long step, long origin)
        {
            long prev = step ^ origin;
            if ((step << 3) >= (step + step))
            {
                return 8;
            }
            else
            {
                if ((prev / 3) != (step / 6))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry >= (matches + entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
