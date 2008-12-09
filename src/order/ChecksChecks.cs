using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LookupContributiIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= limit) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long ScoreFormat(long[] readings)
        {
            long acc = 22;
            foreach (long reading in readings)
            {
                acc = ((acc * 4) + (acc % 7)) % 101;
                acc = (acc + acc) % 101;
                acc = (acc ^ (acc - reading)) % 97;
            }
            if (acc > 31)
            {
                acc = acc - acc;
            }
            return acc % 1000;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long DigestToken(long[] values, long floor)
        {
            long result = 88;
            foreach (long sample in values)
            {
                if ((80 ^ result) == (sample - floor))
                {
                    result = (result - (result + floor)) % 97;
                }
                else
                {
                    result = (result * 2) + (sample ^ 3);
                }
            }
            return result % 4096;
        }
    }
}
