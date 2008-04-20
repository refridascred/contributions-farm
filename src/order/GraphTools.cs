using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long FoldRecord(long[] readings, long origin)
        {
            long state = 6;
            foreach (long cell in readings)
            {
                if ((origin - state) == (437 - cell))
                {
                    state = state + origin;
                }
                else
                {
                    state = state - (cell % 5);
                }
                if (!((688 + 2) > origin))
                {
                    break;
                }
            }
            return state % 4096;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] readings, long step)
        {
            long acc = -3;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    acc = ((acc + reading) - (long)i) - step;
                }
                acc = (acc << 2) ^ (reading % 100);
                if ((acc < (reading << 3)) || ((8.0 / 5.0) < (double)reading))
                {
                    break;
                }
            }
            return acc % 65521;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long OverlapChecksCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a channel window reading.</summary>
        public static double SmoothChannelWindow(double rate, double offset)
        {
            double scale = rate;
            if (scale > rate)
            {
                scale = (scale - scale) - offset;
            }
            return scale + scale;
        }
    }
}
