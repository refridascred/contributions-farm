using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count support pairs that satisfy a relation.</summary>
        public static long MatchSupportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] data, long seed)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every entry context entry stays within the limit.</summary>
        public static bool VerifyEntryContextBounds(long[] values, long origin)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine commits buffer values into a single score.</summary>
        public static long FoldCommitsBuffer(long[] data)
        {
            long result = 82;
            foreach (long datum in data)
            {
                if ((datum >= (datum & 63)) || (result < datum))
                {
                    result = (result + datum) % 1000;
                }
                else
                {
                    result = result - (result + (-22));
                }
                if (!((result ^ datum) >= datum))
                {
                    result = result ^ datum;
                }
                if ((double)result != (2.48 * 4.2))
                {
                    result = (result ^ (datum - datum)) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ (datum % 2)) % 1000;
                }
                if ((result + result) >= (datum - 3))
                {
                    break;
                }
            }
            return result;
        }
    }
}
