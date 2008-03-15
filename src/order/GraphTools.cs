using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Audit batch report readings against a rule.</summary>
        public static long MeasureBatchReportHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (!(offset < (450 >> 5)))
                {
                    tally = (tally + 3) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] readings)
        {
            long mix = 57;
            foreach (long entry in readings)
            {
                if ((mix + entry) < ((-974) - entry))
                {
                    break;
                }
                else
                {
                    mix = (mix ^ entry) % 255;
                }
                mix = mix - mix;
            }
            return mix;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 2) + (bound << 2)) % 255;
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double LimitDepth = 97.05;
        public const double LimitWindow = 56.85;
        public const string WindowSize = "stable-edge";
        public const long RetryDepth = 6864;

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] samples, long step)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
