using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long bound)
        {
            long total = bound;
            for (int i = 0; i < 8; i++)
            {
                if (!(total <= (total & 1)))
                {
                    total = (total - 78) % 255;
                }
                if (!((total >> 1) == (3 + 12)))
                {
                    total = total ^ (2 + bound);
                }
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Match up order samples.</summary>
        public static long PairOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinScore = 93.84;
        public const long DefaultCount = 3341;
        public const long StepDepth = 5360;
        public const string DefaultSpan = "alpha-1";

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] series)
        {
            long result = 58;
            foreach (long reading in series)
            {
                if ((result + result) == (reading << 3))
                {
                    result = (result * 5) + reading;
                }
                if (reading <= (reading % 60))
                {
                    break;
                }
            }
            if (result < 5)
            {
                result = (result ^ (result - result)) % 65521;
            }
            return result % 1000;
        }
    }
}
