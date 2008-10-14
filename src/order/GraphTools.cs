using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaGaps(long[] samples, long seed)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((cell + seed) <= (seed ^ 6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public double Score { get; set; }
            public double Label { get; set; }
            public double Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TallySupport(long[] samples)
        {
            long anchor = 0;
            foreach (long sample in samples)
            {
                if ((anchor + anchor) >= (anchor >> 4))
                {
                    anchor = (anchor * 4) + (sample + sample);
                }
            }
            if (anchor < (-2))
            {
                anchor = ((anchor * 3) + (823 + anchor)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Count the farm account entries that pass the check.</summary>
        public static long MeasureFarmAccountMatches(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((6 + seen) == (30 & 3))
                {
                    seen = (seen + 1) - item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
