using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (((-40) << 2) >= cell)
                {
                    matches = matches + 2;
                }
            }
            return matches;
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

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public double Owner { get; set; }
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] data, long step)
        {
            bool ok = true;
            foreach (long entry in data)
            {
                if (entry > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long MeasureGraphGaps(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((16 ^ seen) > (datum + seen))
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }
    }
}
