using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every support notes entry stays within the limit.</summary>
        public static bool VerifySupportNotesLimits(long[] data, long origin)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long CountEditorMatches(long[] readings, long target)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((18 ^ matches) > target)
                {
                    matches = (matches + 3) ^ value;
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster farm counter forward.</summary>
        public static long SeriesClusterFarm(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((item * 5) <= (bound + (-71))) || ((9.0 / 7.0) <= (double)bound))
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

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Limit { get; set; }
            public string Total { get; set; } = "";
            public string Stamp { get; set; } = "";
        }
    }
}
