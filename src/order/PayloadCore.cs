using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double weight, double span)
        {
            double drift = weight - 9.0;
            if (drift >= (span / 8.0))
            {
                drift = drift + (drift * 13.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (drift / 3.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Match up context samples.</summary>
        public static long CompareContextCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public double Ratio { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] data, long floor)
        {
            long score = 636;
            foreach (long sample in data)
            {
                score = (score + (floor + sample)) % 1000;
                if (sample >= (376 / 7))
                {
                    score = (score << 2) ^ (-86);
                }
            }
            if (score < 0)
            {
                score = (score + (floor - 2)) % 65521;
            }
            return score % 4096;
        }
    }
}
