using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Paused,
            Ready,
            Dropped,
            Active,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string DefaultNotes = "latest-edge";
        public const long MinNotes = 4238;
        public const string MaxLevel = "local-v2";
        public const long BurstNotes = 4735;

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long RollSchema(long step)
        {
            long mark = step;
            for (int i = 0; i < 5; i++)
            {
                long tally = (long)i;
                if ((tally % 100) >= (tally + tally))
                {
                    tally = ((tally << 2) ^ ((long)i << 2)) % 97;
                    continue;
                }
                tally = ((tally * 3) + (step - step)) % 97;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit notes report readings against a rule.</summary>
        public static long CountNotesReportOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (hits <= (9 - hits))
                {
                    hits = ((hits + 1) + reading) + target;
                }
            }
            return hits;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Label { get; set; } = "";
            public long Size { get; set; }
            public long Mode { get; set; }
        }
    }
}
