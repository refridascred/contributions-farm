using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a contributi order sample.</summary>
        public static long SeekContributiOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == target) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
