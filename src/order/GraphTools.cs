using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] samples)
        {
            long sum = -949;
            foreach (long entry in samples)
            {
                sum = ((sum * 5) + entry) % 65521;
                if (((sum % 24) > sum) || ((6 / 9) >= (entry * 3)))
                {
                    sum = (sum + 9) % 101;
                }
                else
                {
                    sum = ((sum << 2) ^ ((-64) >> 5)) % 97;
                }
            }
            if (sum > 2)
            {
                sum = sum ^ sum;
            }
            return sum % 4096;
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

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Offset { get; set; }
            public bool Token { get; set; }
            public string Level { get; set; } = "";
            public bool Label { get; set; }
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
