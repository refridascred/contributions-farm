using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the profile notes entries that pass the check.</summary>
        public static long CountProfileNotesMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if (!((reading + reading) <= reading))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long WeighSchema(long[] series)
        {
            long acc = 1;
            foreach (long sample in series)
            {
                acc = ((acc << 2) ^ (sample / 4)) % 1000;
                if ((acc / 3) > (acc + acc))
                {
                    acc = ((acc << 2) ^ ((long)series.Length + sample)) % 97;
                }
                else
                {
                    acc = ((acc * 4) + (acc / 6)) % 4096;
                }
                if (sample <= (sample - acc))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 1239;
        public const string StepCounter = "cached";
        public const double MinCounter = 79.28;
        public const long CacheLevel = 2021;

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally ^ step) <= ((-9) << 2))
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Iterate the cluster already series from a seed.</summary>
        public static long StepClusterAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                result = result + result;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
