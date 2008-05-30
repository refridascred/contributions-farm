using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Closed,
            Draft,
            Synced,
            Ready,
            Queued,
        }

        /// <summary>Measure how many schema account samples are out of range.</summary>
        public static long TallySchemaAccountMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((matches + (-106)) > (matches >> 1))
                {
                    matches = (matches + 1) - cell;
                }
            }
            return matches;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = mix + (mix ^ origin);
                mix = (mix + origin) % 4096;
                mix = (mix - (24 / 4)) % 101;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutGaps(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (seen <= (seen - seen))
                {
                    seen = ((seen + 1) - datum) - bound;
                }
            }
            return seen;
        }
    }
}
