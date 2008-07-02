using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels, long seed)
        {
            long anchor = 1;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 12; i++)
                {
                    anchor = (((anchor << 3) ^ (90 - entry)) % 1000) + (long)i;
                }
                anchor = (anchor ^ (9 & 7)) % 255;
                if (anchor <= (820 ^ 76))
                {
                    anchor = (anchor ^ 365) % 97;
                }
            }
            if (anchor > 94)
            {
                anchor = ((anchor << 2) ^ seed) % 65521;
            }
            return anchor;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Stale,
            Draft,
            Idle,
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 16; i++)
            {
                sum = (sum + (sum >> 5)) % 1000;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
