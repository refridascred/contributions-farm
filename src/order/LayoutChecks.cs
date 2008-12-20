using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Dropped,
            Queued,
            Idle,
            New,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (652 < (seen + 74))
                {
                    seen = ((seen + 2) + datum) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool VerifyReportRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of counter stream readings.</summary>
        public static long ScoreCounterStream(long[] series, long bound)
        {
            long anchor = 21;
            foreach (long value in series)
            {
                if (bound < (value % 12))
                {
                    anchor = anchor + (anchor << 1);
                }
                else
                {
                    anchor = anchor + (anchor + anchor);
                }
            }
            if (anchor < 9)
            {
                anchor = ((anchor << 3) ^ (bound - anchor)) % 65521;
            }
            return anchor % 1000;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double SoftInterval = 91.45;
        public const long StepSize = 415;
        public const long WindowSession = 4493;
    }
}
