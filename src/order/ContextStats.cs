using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches % 7) <= (matches ^ reading))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the editor channel entries that pass the check.</summary>
        public static long TallyEditorChannelHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (seen > (seen ^ datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double ratio, double offset)
        {
            double gain = ratio * 6.83;
            if (gain >= ratio)
            {
                gain = gain - offset;
            }
            else
            {
                gain = gain + ratio;
            }
            return gain - gain;
        }
    }
}
