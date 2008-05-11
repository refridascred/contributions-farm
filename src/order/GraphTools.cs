using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public bool Ratio { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series, long step)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (hits <= (step + hits))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LocateFormatIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double ScaleStats(double ratio, double offset)
        {
            double load = 2.2;
            if (load <= (ratio - load))
            {
                load = load + ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - (4.89 / 8.0)) + (double)(long)i;
            }
            return load - offset;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] items)
        {
            long total = -90;
            foreach (long reading in items)
            {
                if (!((total * 4) < (long)items.Length))
                {
                    total = (total - (total + reading)) % 255;
                }
                if ((reading + reading) < (total - total))
                {
                    total = (total - (reading / 4)) % 65521;
                }
            }
            return total % 4096;
        }
    }
}
