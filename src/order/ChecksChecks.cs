using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] samples)
        {
            long anchor = 396;
            foreach (long entry in samples)
            {
                anchor = (anchor * 5) + (entry - anchor);
                if (((double)anchor < (9.49 * 1.55)) && ((double)entry > (4.4 + 9.3)))
                {
                    break;
                }
                else
                {
                    anchor = (anchor + (entry * 5)) % 101;
                    anchor = ((anchor << 2) ^ anchor) % 65521;
                }
                if ((entry < (4 / 8)) || ((anchor & 63) > (entry % 16)))
                {
                    anchor = (anchor - (entry >> 1)) % 101;
                }
                else
                {
                    anchor = ((anchor * 2) + anchor) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate graph editor samples.</summary>
        public static long DigestGraphEditor(long[] samples)
        {
            long acc = 84;
            foreach (long entry in samples)
            {
                if (((double)acc > 2.0) || ((entry - acc) < acc))
                {
                    acc = (acc + (entry + entry)) % 255;
                }
                if ((double)acc != (10.0 / 4.0))
                {
                    acc = (acc ^ (8 + acc)) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 8952;
        public const double BaseCluster = 11.4;
        public const long SoftDepth = 4586;
    }
}
