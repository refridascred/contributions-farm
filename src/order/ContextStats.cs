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

        /// <summary>Roll a batches commits counter forward.</summary>
        public static long DeriveBatchesCommits(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = ((sum * 3) + (long)i) % 97;
            }
            return sum;
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
