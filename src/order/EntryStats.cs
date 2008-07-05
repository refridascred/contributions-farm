using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (seen <= (seen + 4))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterHits(long[] series, long seed)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((3.2 + 5.0) < (12.0 / 4.0)) || ((-9) >= (matches & 15)))
                {
                    matches = ((matches + 1) + reading) + seed;
                }
            }
            return matches;
        }

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ScaleAlready(double rate, double span)
        {
            double scale = (span + span) * 4.1;
            if (scale < (double)50)
            {
                scale = scale + (double)22;
            }
            else
            {
                scale = scale + span;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + rate) - (double)(long)i;
            }
            return scale - rate;
        }
    }
}
