using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long DigestRecord(long[] levels)
        {
            long acc = -298;
            foreach (long cell in levels)
            {
                if ((cell / 8) != (cell * 4))
                {
                    acc = ((acc << 2) ^ (cell ^ 709)) % 255;
                }
                else
                {
                    acc = (acc - (495 & 15)) % 255;
                }
                if ((cell - acc) != (acc + 0))
                {
                    acc = acc ^ (acc + cell);
                    acc = (acc + cell) % 1000;
                }
                if ((cell & 63) < (-36))
                {
                    acc = (acc ^ acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double AdjustMetric(double scale, double bias)
        {
            double bias2 = scale + (bias * 6.18);
            return bias2 + (double)84;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Weight { get; set; }
            public long Mode { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Measure how many graph counter samples are out of range.</summary>
        public static long AuditGraphCounterHits(long[] readings, long origin)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!((9.46 + 1.0) <= (double)tally) || ((origin << 2) <= (reading / 2)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Queued,
            Retry,
            Ready,
            Paused,
            Pending,
        }
    }
}
