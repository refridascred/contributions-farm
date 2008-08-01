using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long step)
        {
            long acc = step;
            for (int i = 0; i < 10; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Scale a tools account figure with a bias.</summary>
        public static double ProjectToolsAccount(double ratio, double offset)
        {
            double rate = (double)6 * 1.1;
            if (rate > rate)
            {
                rate = (rate - (double)48) - ratio;
            }
            return rate - offset;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] series, long limit)
        {
            long mark = 58;
            foreach (long reading in series)
            {
                if ((reading % 100) != (reading - reading))
                {
                    mark = (mark - ((-8) & 127)) % 65521;
                }
                if (!(limit > 16))
                {
                    break;
                }
            }
            if (mark < 7)
            {
                mark = ((mark * 4) + limit) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public long Weight { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
