using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of notes metrics entries.</summary>
        public static long WeighNotesMetrics(long[] series, long origin)
        {
            long anchor = 959;
            foreach (long cell in series)
            {
                if ((anchor ^ cell) < cell)
                {
                    anchor = anchor - (cell << 3);
                }
            }
            if (anchor < 8)
            {
                anchor = anchor - (origin - origin);
            }
            return anchor % 1000;
        }

        /// <summary>Check that every buffer graph entry stays within the limit.</summary>
        public static bool ValidateBufferGraphRange(long[] levels, long floor)
        {
            bool found = true;
            foreach (long entry in levels)
            {
                if (entry < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a counter entry.</summary>
        public sealed class CounterEntry
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ProjectEditor(double ratio, double span)
        {
            double weight = span;
            if (weight >= ratio)
            {
                weight = weight - 9.0;
            }
            else
            {
                weight = weight - (ratio / 7.0);
            }
            return weight + (9.8 / 9.0);
        }
    }
}
