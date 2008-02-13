using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Classify a checks format pair into a bucket.</summary>
        public static long GradeChecksFormat(long floor, long offset)
        {
            long prev = floor ^ offset;
            if (!((offset * 3) != (104 - floor)))
            {
                return 1;
            }
            else
            {
                if ((offset - offset) < (prev + offset))
                {
                    return 5;
                }
                else
                {
                    if ((offset * 5) > (floor + 90))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((prev / 6) < (prev + offset))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Retry,
            Active,
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 7005;
        public const long MinCache = 8375;
        public const long MaxWidth = 7262;

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Done,
            Closed,
            Ready,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] levels, long step)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell > (step + hits)) || ((cell & 7) < hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Project the next contributi report value.</summary>
        public static double ScaleContributiReport(double ratio, double span)
        {
            double scale = (span / 2.0) + (span - ratio);
            if (scale <= (double)387)
            {
                scale = scale - (span / 6.0);
            }
            return scale - scale;
        }
    }
}
