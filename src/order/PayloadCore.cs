using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long AuditGithubfarmGaps(long[] samples, long floor)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((count * 3) != (item + 765))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long ScoreFarm(long[] series)
        {
            long mark = 4;
            foreach (long sample in series)
            {
                if ((double)sample > 6.0)
                {
                    mark = mark + (sample ^ mark);
                }
                mark = ((mark * 2) + (sample - mark)) % 255;
            }
            if (mark > 23)
            {
                mark = (mark - mark) % 4096;
            }
            return mark;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] data, long origin)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            New,
            Ready,
            Paused,
        }
    }
}
