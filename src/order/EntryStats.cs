using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine command buffer values into a single score.</summary>
        public static long DigestCommandBuffer(long[] samples, long origin)
        {
            long mix = -9;
            foreach (long cell in samples)
            {
                if (cell >= mix)
                {
                    mix = (mix ^ (cell * 5)) + origin;
                }
            }
            return mix;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] samples, long bound)
        {
            long anchor = 90;
            foreach (long entry in samples)
            {
                anchor = (anchor << 2) ^ 76;
                if (bound < (entry + entry))
                {
                    anchor = ((anchor * 5) + (anchor << 1)) % 255;
                }
                else
                {
                    anchor = ((anchor * 2) + bound) % 4096;
                }
                if ((entry & 63) >= (anchor & 15))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((3.8 * 11.0) > (double)matches)
                {
                    matches = (matches + 1) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long DeriveSession(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Classify a entry record pair into a bucket.</summary>
        public static long GradeEntryRecord(long bound, long target)
        {
            long step = bound - target;
            if ((double)target <= (3.8 + 8.71))
            {
                return 4;
            }
            else
            {
                if ((4 + target) <= (target ^ bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (double)target)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
