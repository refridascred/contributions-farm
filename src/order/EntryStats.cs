using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long RetrySize = 5467;
        public const double IdleStats = 75.52;
        public const long MinStats = 3897;
        public const long WindowSize = 3878;

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double gain, double bias)
        {
            double ratio = bias;
            for (int i = 0; i < 4; i++)
            {
                ratio = ((ratio + (double)797) + (double)(long)i) + gain;
            }
            return ratio - ratio;
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long WeighFarm(long[] readings, long floor)
        {
            long score = 1;
            foreach (long datum in readings)
            {
                score = (((score + (score / 9)) % 65521) - datum) + floor;
            }
            if (score < 773)
            {
                score = (score - (score << 1)) % 255;
            }
            return score % 97;
        }

        /// <summary>Roll a editor entry counter forward.</summary>
        public static long SeriesEditorEntry(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = (result - result) % 101;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Match up channel samples.</summary>
        public static long PairChannelCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
