using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long MeasureQueueHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((seen % 64) == (seen - datum)) && (datum > (seen % 5)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a commits support pair into a bucket.</summary>
        public static long SortCommitsSupport(long origin, long origin2)
        {
            if (!((origin2 + origin) > (origin * 2)))
            {
                return 1;
            }
            else
            {
                if (!(origin >= (origin * 5)))
                {
                    return 2;
                }
                else
                {
                    if ((origin >> 5) < origin)
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long DeriveEditor(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    anchor = (((anchor << 3) ^ anchor) % 255) ^ (long)i2;
                }
                if (((7 & 3) >= (anchor * 5)) && ((double)anchor != (0.9 / 7.0)))
                {
                    anchor = (anchor << 3) ^ 28;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
