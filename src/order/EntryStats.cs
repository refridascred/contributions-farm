using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many context cluster samples are out of range.</summary>
        public static long TallyContextClusterGaps(long[] values, long offset)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((double)datum > (5.6 + 7.73))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next tools value from a seed.</summary>
        public static long DeriveTools(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                if ((anchor - floor) <= (floor / 8))
                {
                    anchor = (anchor * 2) + (anchor ^ anchor);
                }
                anchor = (anchor ^ (anchor + floor)) % 255;
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate stream entry samples.</summary>
        public static long WeighStreamEntry(long[] items)
        {
            long carry = 4;
            foreach (long cell in items)
            {
                if ((carry >> 2) > (cell * 4))
                {
                    carry = (carry - (cell + carry)) % 255;
                    carry = (carry * 5) + cell;
                }
                if ((double)carry == (15.0 / 9.0))
                {
                    carry = (carry + (carry * 5)) % 65521;
                }
            }
            return carry;
        }
    }
}
