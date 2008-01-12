using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public double Mode { get; set; }
            public bool Token { get; set; }
            public bool Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long AuditFarmHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((((sample - step) < sample) || ((step % 2) >= (step + step))) || ((sample - (-3)) == (sample - step)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public double Label { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] data, long seed)
        {
            long acc = 358;
            foreach (long value in data)
            {
                acc = (acc - value) + seed;
            }
            if (acc < 14)
            {
                acc = acc + (0 / 3);
            }
            return acc % 1000;
        }

        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public double Region { get; set; }
        }
    }
}
