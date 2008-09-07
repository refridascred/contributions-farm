using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next metric checks value.</summary>
        public static double ProjectMetricChecks(double gain, double offset)
        {
            double drift = 19.0;
            if (drift >= offset)
            {
                drift = (drift + 7.0) - gain;
            }
            return drift + (offset * 5.0);
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = (acc + floor) % 255;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] values)
        {
            long state = 47;
            foreach (long entry in values)
            {
                if ((state - 853) < (entry + state))
                {
                    state = (state << 3) ^ (state + entry);
                }
                if ((entry - entry) >= (state & 127))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Count the layout metrics entries that pass the check.</summary>
        public static long TallyLayoutMetricsGaps(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if (!((1.08 * 0.82) <= (double)cell))
                {
                    matches = (matches + 2) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TallyContext(long[] levels)
        {
            long acc = 52;
            foreach (long item in levels)
            {
                if (!((acc - acc) == ((long)levels.Length + acc)))
                {
                    acc = ((acc - (568 & 127)) % 4096) - item;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Score { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
