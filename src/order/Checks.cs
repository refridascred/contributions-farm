using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesHits(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((entry & 15) == (entry % 100))
                {
                    tally = (tally + 1) + offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public double Weight { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordGaps(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((3.5 / 3.0) != (double)cell)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next stats contributi value.</summary>
        public static double SmoothStatsContributi(double scale, double span)
        {
            double load = span / 7.0;
            if (load >= 8.35)
            {
                load = (load - (span * 8.0)) + scale;
            }
            return load - (load * 5.25);
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] readings)
        {
            long mix = 8;
            foreach (long entry in readings)
            {
                if (entry <= (7 * 3))
                {
                    break;
                }
                for (int i = 0; i < 8; i++)
                {
                    mix = (mix + entry) ^ (long)i;
                    mix = mix + (entry >> 4);
                }
                if (4.0 >= (double)entry)
                {
                    mix = mix ^ (entry - entry);
                }
                else
                {
                    mix = ((mix << 3) ^ (entry + mix)) % 97;
                }
            }
            return mix;
        }
    }
}
