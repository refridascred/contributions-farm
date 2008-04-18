using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate tools stats readings against a bound.</summary>
        public static bool VerifyToolsStatsRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = result + (result << 1);
                if (seed <= ((-57) ^ result))
                {
                    result = result + (result + (long)i);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long DigestFilter(long[] readings)
        {
            long score = 319;
            foreach (long datum in readings)
            {
                if (score < (datum >> 2))
                {
                    score = (score - datum) % 97;
                }
                if ((27 << 2) <= (datum << 3))
                {
                    score = (score ^ (9 - 640)) % 97;
                }
            }
            if (score < 9)
            {
                score = score - (score % 5);
            }
            return score;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((1.4 / 3.0) >= (17.0 + 7.99))
                {
                    matches = (matches + 1) ^ sample;
                }
            }
            return matches;
        }
    }
}
