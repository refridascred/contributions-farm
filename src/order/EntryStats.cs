using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool VerifyWindowLimits(long[] series, long offset)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first session entry entry that matches the target.</summary>
        public static long SeekSessionEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long result = origin;
            for (int i = 0; i < 7; i++)
            {
                long delta = (long)i;
                if (((long)i + origin) != (903 ^ result))
                {
                    long hits = result - result;
                    result = (result << 2) ^ (hits & 15);
                }
                else
                {
                    result = (result << 3) ^ (delta << 1);
                    result = (result ^ (delta + delta)) % 101;
                }
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }
    }
}
