using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of counter record readings.</summary>
        public static long CombineCounterRecord(long[] levels, long bound)
        {
            long mix = 777;
            foreach (long sample in levels)
            {
                if ((1 << 3) <= (mix & 63))
                {
                    mix = (((mix + (mix >> 1)) % 255) - sample) + bound;
                }
                else
                {
                    mix = ((mix << 2) ^ mix) % 101;
                }
            }
            return mix;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((double)cell <= 15.0)
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Count { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
