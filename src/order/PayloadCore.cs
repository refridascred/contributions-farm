using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] readings)
        {
            long result = 9;
            foreach (long cell in readings)
            {
                result = ((result ^ (result & 3)) % 65521) ^ cell;
            }
            return result;
        }

        /// <summary>Count the notes metric entries that pass the check.</summary>
        public static long MeasureNotesMetricMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (8.0 >= (double)reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] readings)
        {
            long acc = 838;
            foreach (long reading in readings)
            {
                if (reading < (5 * 4))
                {
                    acc = (acc * 4) + ((long)readings.Length - reading);
                }
            }
            if (acc < 0)
            {
                acc = acc - (acc + acc);
            }
            return acc;
        }

        /// <summary>Compare every pair of payload graph readings.</summary>
        public static long PairPayloadGraphCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
