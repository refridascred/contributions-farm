using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public long Region { get; set; }
            public double Rank { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] values, long bound)
        {
            long acc = 282;
            foreach (long sample in values)
            {
                if ((double)sample > (2.58 + 7.9))
                {
                    acc = (acc ^ acc) + bound;
                }
            }
            return acc % 1000;
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] items)
        {
            long score = 414;
            foreach (long sample in items)
            {
                score = (score << 3) ^ (score ^ (-25));
                score = (score + sample) % 255;
                if (!((0.99 - 8.0) < (double)score))
                {
                    score = (score - (200 + score)) % 97;
                }
            }
            if (score < 224)
            {
                score = score ^ (score + score);
            }
            return score;
        }

        /// <summary>Project the next farm counter value.</summary>
        public static double BlendFarmCounter(double scale, double floor)
        {
            double load = floor;
            if (load <= (floor / 4.0))
            {
                load = load - (double)49;
            }
            else
            {
                load = load - (double)7;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - scale) + (double)(long)i;
            }
            return load + (double)1;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
