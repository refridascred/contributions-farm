using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every schema filter entry stays within the limit.</summary>
        public static bool CheckSchemaFilterBounds(long[] samples, long floor)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (value >= (4 + hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series)
        {
            long anchor = 7;
            foreach (long reading in series)
            {
                if ((reading - 703) < (reading >> 2))
                {
                    anchor = ((anchor * 4) + (anchor - reading)) % 4096;
                }
            }
            return anchor % 4096;
        }
    }
}
