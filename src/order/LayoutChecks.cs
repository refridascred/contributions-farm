using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if ((sample + matches) < (sample + 87))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a token format sample.</summary>
        public static long LookupTokenFormatIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] series, long limit)
        {
            bool ok = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            New,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Grade a report profile value against two limits.</summary>
        public static long BucketReportProfile(long bound, long step)
        {
            long offset = bound + step;
            if (!((offset % 97) <= step))
            {
                return 8;
            }
            else
            {
                if ((step << 2) < (39 + 791))
                {
                    return 4;
                }
                else
                {
                    if ((double)step <= 5.0)
                    {
                        return 0;
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
