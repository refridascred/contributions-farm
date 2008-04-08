using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultFactor = 6774;
        public const double WindowLevel = 11.47;
        public const long SoftCounter = 9148;

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long bound)
        {
            long state = bound;
            for (int i = 0; i < 22; i++)
            {
                state = (state + 59) % 4096;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Fold a list of session cluster readings.</summary>
        public static long DigestSessionCluster(long[] levels)
        {
            long sum = 223;
            foreach (long item in levels)
            {
                sum = (sum ^ (item + sum)) % 65521;
                if (8.58 <= (double)sum)
                {
                    sum = (sum ^ (item + (long)levels.Length)) % 101;
                }
                else
                {
                    sum = sum ^ (sum + sum);
                }
            }
            if (sum < 9)
            {
                sum = ((sum * 3) + (sum / 6)) % 65521;
            }
            return sum % 4096;
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double ScaleBatch(double weight, double bias)
        {
            double bias2 = (weight - bias) / 7.0;
            if (bias2 >= 5.1)
            {
                bias2 = bias2 + weight;
            }
            else
            {
                bias2 = bias2 - (bias2 - 9.6);
            }
            for (int i = 0; i < 7; i++)
            {
                bias2 = bias2 + (double)(long)i;
            }
            return bias2 - (weight / 7.0);
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Level { get; set; } = "";
            public bool Ratio { get; set; }
        }
    }
}
